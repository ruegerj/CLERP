using CLERP.API.Domain.Models;
using CLERP.API.Domain.Models.Abstract;
using CLERP.API.Domain.Models.Link;
using CLERP.API.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Contexts
{
    /// <summary>
    /// Db-Context for ClerpDb
    /// </summary>
    public class ClerpContext : DbContext
    {
        private readonly ILogger<ClerpContext> _logger;
        private readonly ICurrentUserAccessor _currentUserAccessor;

        private IDbContextTransaction _currentTransaction;

        /// <summary>
        /// Include context options e.g. Connection-String etc.
        /// </summary>
        /// <param name="options">Options injected by the builder</param>
        public ClerpContext(DbContextOptions<ClerpContext> options, 
                            ILogger<ClerpContext> logger,
                            ICurrentUserAccessor currentUserAccessor) : base(options)
        {
            _logger = logger;
            _currentUserAccessor = currentUserAccessor;
        }

        /// <summary>
        /// Db-Configurations using <see cref="IEntityTypeConfiguration{TEntity}"/>
        /// </summary>
        /// <param name="modelBuilder">current <see cref="ModelBuilder"/> instance</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            RegisterConfigurations(modelBuilder);
        }

        // Ordinary Tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Compartment> Compartments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<BusinessPartner> BusinessPartners { get; set; }
        public DbSet<BusinessContact> BusinessContacts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ContactLog> ContactLogs { get; set; }
        public DbSet<PartnerLog> PartnerLogs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Bill> Bills { get; set; }

        // Link-Tables
        public DbSet<RoleEmployee> RolesEmployees { get; set; }
        public DbSet<RoleDepartment> RolesDepartments { get; set; }
        public DbSet<ProductTypeProductType> ProductTypesProductTypes { get; set; }
        public DbSet<ProductTypeOrder> ProductTypesOrders { get; set; }

        #region Transaction Handling

        public void BeginTransaction()
        {
            if (_currentTransaction != null)
            {                
                return;
            }

            if (!Database.IsInMemory())
            {
                _currentTransaction = Database.BeginTransaction(IsolationLevel.ReadCommitted);
                _logger.LogDebug($"Begin transaction id: {_currentTransaction.TransactionId}.");
            }
        }

        public void CommitTransaction()
        {
            try
            {
                _currentTransaction?.Commit();
                _logger.LogDebug($"Commit transaction id: {_currentTransaction.TransactionId}.");
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
                _logger.LogWarning($"Rollback transaction id: {_currentTransaction.TransactionId}.");
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        #endregion

        /// <summary>
        /// SaveChanges which additionally updates the metadata of all changed entities
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            RegisterMetaData();

            return base.SaveChanges();
        }

        /// <summary>
        /// SaveChangesAsync which additionally updates the metadata of all changed entities
        /// </summary>
        /// <returns></returns>
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            RegisterMetaData();

            return await base.SaveChangesAsync();
        }

        #region Utilities

        private void RegisterMetaData()
        {
            DateTime now = DateTime.Now;

            string currentUsername = _currentUserAccessor.GetUsername();
            string username  = !String.IsNullOrEmpty(currentUsername) ? currentUsername : "Unknown user";

            var addedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();

            addedEntities.ForEach(ae =>
            {
                ae.Property("Creation").CurrentValue = now;
                ae.Property("CreatedBy").CurrentValue = username;
                ae.Property("LastModified").CurrentValue = now;
                ae.Property("LastModifiedBy").CurrentValue = username;
            });

            var updatedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();

            updatedEntities.ForEach(ue =>
            {
                ue.Property("LastModified").CurrentValue = now;
                ue.Property("LastModifiedBy").CurrentValue = username;
            });
        }

        /// <summary>
        /// Method to bulk register all entity configurations
        /// </summary>
        /// <param name="builder">current <see cref="ModelBuilder"/> instance</param>
        private void RegisterConfigurations(ModelBuilder builder)
        {
            var applyGenericMethods = typeof(ModelBuilder).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            var applyGenericApplyConfigurationMethods = applyGenericMethods.Where(m => m.IsGenericMethod && m.Name.Equals("ApplyConfiguration", StringComparison.OrdinalIgnoreCase));
            var applyGenericMethod = applyGenericApplyConfigurationMethods.Where(m => m.GetParameters().FirstOrDefault().ParameterType.Name == "IEntityTypeConfiguration`1").FirstOrDefault();

            // replace GetExecutingAssembly with assembly where the configurations are if necessary
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(c => c.IsClass && !c.IsAbstract && !c.ContainsGenericParameters))
            {
                // use type.Namespace to filter by namespace if necessary
                foreach (var iface in type.GetInterfaces())
                {
                    // if type implements interface IEntityTypeConfiguration<SomeEntity>
                    if (iface.IsConstructedGenericType && iface.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                    {
                        // make concrete ApplyConfiguration<SomeEntity> method
                        var applyConfigurationConcrete = applyGenericMethod.MakeGenericMethod(iface.GenericTypeArguments[0]);
                        // and invoke with instance of configuration type
                        applyConfigurationConcrete.Invoke(builder, new object[] { Activator.CreateInstance(type) });
                        break;
                    }
                }
            }
        }

        #endregion
    }
}
