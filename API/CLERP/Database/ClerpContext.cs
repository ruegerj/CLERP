using CLERP.Database.Configurations;
using CLERP.Database.Configurations.Link;
using CLERP.Database.Entities;
using CLERP.Database.Entities.Abstract;
using CLERP.Database.Entities.Link;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CLERP.Database
{
    /// <summary>
    /// Db-Context for ClerpDb
    /// </summary>
    public class ClerpContext : DbContext
    {
        /// <summary>
        /// Include context options e.g. Connection-String etc.
        /// </summary>
        /// <param name="options">Options injected by the builder</param>
        public ClerpContext(DbContextOptions<ClerpContext> options) : base(options) { }

        /// <summary>
        /// Db-Configurations via the Fluent-Api
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
    }
}
