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

            #region Table renaming

            modelBuilder.Entity<Role>()
                .ToTable(nameof(Roles).ToLower());

            modelBuilder.Entity<Department>()
                .ToTable(nameof(Departments).ToLower());

            modelBuilder.Entity<Employee>()
                .ToTable(nameof(Employees).ToLower());

            modelBuilder.Entity<Warehouse>()
                .ToTable(nameof(Warehouses).ToLower());

            modelBuilder.Entity<Shelf>()
                .ToTable(nameof(Shelves).ToLower());

            modelBuilder.Entity<Compartment>()
                .ToTable(nameof(Compartments).ToLower());

            modelBuilder.Entity<Product>()
                .ToTable(nameof(Products).ToLower());

            modelBuilder.Entity<Country>()
                .ToTable(nameof(Countries).ToLower());

            modelBuilder.Entity<City>()
                .ToTable(nameof(Cities).ToLower());

            modelBuilder.Entity<Address>()
                 .ToTable(nameof(Addresses).ToLower());

            modelBuilder.Entity<Order>()
                .ToTable(nameof(Orders).ToLower());

            modelBuilder.Entity<ContactLog>()
                .ToTable("business-contact-logs");

            modelBuilder.Entity<PartnerLog>()
                .ToTable("business-partner-logs");

            modelBuilder.Entity<ProductType>()
                .ToTable("product-types");

            modelBuilder.Entity<BusinessPartner>()
                .ToTable("business-partners");

            modelBuilder.Entity<BusinessContact>()
                .ToTable("business-contacts");

            modelBuilder.Entity<RoleDepartment>()
                .ToTable("roles_departments");

            modelBuilder.Entity<RoleEmployee>()
                .ToTable("roles_employees");

            modelBuilder.Entity<ProductTypeProductType>()
                .ToTable("product-types_product-types");

            #endregion

            #region Table configurations            

            modelBuilder = ConfigureRole(modelBuilder);

            modelBuilder = ConfigureDepartment(modelBuilder);

            modelBuilder = ConfigureEmployee(modelBuilder);

            modelBuilder = ConfigureAddress(modelBuilder);

            modelBuilder = ConfigureWarehouse(modelBuilder);

            modelBuilder = ConfigureShelf(modelBuilder);

            modelBuilder = ConfigureCompartment(modelBuilder);

            modelBuilder = ConfigureProduct(modelBuilder);

            modelBuilder = ConfigureBusinessPartner(modelBuilder);

            modelBuilder = ConfigureBusinessContact(modelBuilder);

            modelBuilder = ConfigureCountry(modelBuilder);

            modelBuilder = ConfigureCity(modelBuilder);

            modelBuilder = ConfigureProductType(modelBuilder);

            modelBuilder = ConfigureLogEntry<ContactLog>(modelBuilder);

            modelBuilder = ConfigureLogEntry<PartnerLog>(modelBuilder);

            modelBuilder = ConfigureOrder(modelBuilder);

            #endregion

            #region Table relations

            // Role m-m Department
            modelBuilder.Entity<RoleDepartment>()
                .HasKey(x => new { x.RoleGuid, x.DepartmentGuid });

            modelBuilder.Entity<RoleDepartment>()
                .HasOne(x => x.Role)
                .WithMany(y => y.Departments)
                .HasForeignKey(y => y.DepartmentGuid);

            modelBuilder.Entity<RoleDepartment>()
                .HasOne(x => x.Department)
                .WithMany(y => y.Roles)
                .HasForeignKey(y => y.RoleGuid);

            // Role m-m Employee
            modelBuilder.Entity<RoleEmployee>()
                .HasKey(x => new { x.RoleId, x.EmployeeId });

            modelBuilder.Entity<RoleEmployee>()
                .HasOne(x => x.Role)
                .WithMany(y => y.Employees)
                .HasForeignKey(y => y.EmployeeId);

            modelBuilder.Entity<RoleEmployee>()
                .HasOne(x => x.Employee)
                .WithMany(y => y.Roles)
                .HasForeignKey(y => y.RoleId);

            // Parent Product-Type m-m Child Product-Type
            modelBuilder.Entity<ProductTypeProductType>()
                .HasKey(x => new { x.ChildGuid, x.ParentGuid });

            modelBuilder.Entity<ProductTypeProductType>()
                .HasOne(x => x.Parent)
                .WithMany(y => y.Children)
                .HasForeignKey(y => y.ChildGuid)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductTypeProductType>()
                .HasOne(x => x.Child)
                .WithMany(y => y.Parents)
                .HasForeignKey(y => y.ParentGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Address 1-1 Warehouse 
            modelBuilder.Entity<Address>()
                .HasOne(x => x.Warehouse)
                .WithOne(y => y.Address)
                .HasForeignKey<Warehouse>(y => y.AddressGuid);

            // Address 1-m Order (Shipping-Address)
            modelBuilder.Entity<Address>()
                .HasMany(x => x.ShippingOrders)
                .WithOne(y => y.ShippingAddress)
                .HasForeignKey(y => y.ShippingAddressGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Address 1-m Order (Billing-Address)
            modelBuilder.Entity<Address>()
                .HasMany(x => x.BillingOrders)
                .WithOne(y => y.BillingAddress)
                .HasForeignKey(y => y.BillingAddressGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Business-Partner 1-m Order (Receiving)
            modelBuilder.Entity<BusinessPartner>()
                .HasMany(x => x.ReceivedOrders)
                .WithOne(y => y.ReceivingPartner)
                .HasForeignKey(y => y.ReceivingPartnerGuid)
                .OnDelete(DeleteBehavior.Restrict);

            // Business-Partner 1-m Order (Sending)
            modelBuilder.Entity<BusinessPartner>()
                .HasMany(x => x.SendtOrders)
                .WithOne(y => y.SendingPartner)
                .HasForeignKey(y => y.SendingPartnerGuid)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Value Converters

            var roleTypeConverter = new ValueConverter<RoleType, string>(
                v => v.ToString(), // value -> Db
                v => (RoleType)Enum.Parse(typeof(RoleType), v)); // value <- Db

            modelBuilder.Entity<Role>()
                .Property(x => x.Type)
                .HasConversion(roleTypeConverter);

            var countryAbbrevationConverter = new ValueConverter<string, string>
                (
                    v => v.ToUpperInvariant(),
                    v => v
                );

            modelBuilder.Entity<Country>()
                .Property(x => x.Abbreviation)
                .HasConversion(countryAbbrevationConverter);

            var productStateConverter = new ValueConverter<ProductState, string>
                (
                    v => v.ToString(),
                    v => (ProductState)Enum.Parse(typeof(ProductState), v)
                );

            modelBuilder.Entity<Product>()
                .Property(x => x.State)
                .HasConversion(productStateConverter);

            var orderStateConverter = new ValueConverter<OrderState, string>
                (
                    v => v.ToString(),
                    v => (OrderState)Enum.Parse(typeof(OrderState), v)
                );

            modelBuilder.Entity<Order>()
                .Property(x => x.State)
                .HasConversion(orderStateConverter);

            #endregion
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

        // Link-Tables
        public DbSet<RoleEmployee> RolesEmployees { get; set; }
        public DbSet<RoleDepartment> RolesDepartments { get; set; }
        public DbSet<ProductTypeProductType> ProductTypesProductTypes { get; set; }

        #region Configurators for entities

        /// <summary>
        /// Configures all shared attributes of an entity which inherits from <see cref="EntityBase"/>
        /// </summary>
        /// <typeparam name="T">Type of the sub class</typeparam>
        /// <param name="builder">current <see cref="ModelBuilder"/> instance</param>
        private ModelBuilder ConfigureBaseFields<T>(ModelBuilder builder) where T : EntityBase
        {
            builder.Entity<T>()
                .HasKey(x => x.Guid);

            // Set auto generate for GUID in Db
            builder.Entity<T>()
                .Property(x => x.Guid)
                .HasDefaultValueSql("NEWID()");

            builder.Entity<T>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<T>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<T>()
                .Property(x => x.CreatedBy)
                .IsRequired();

            builder.Entity<T>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<T>()
                .Property(x => x.LastModifiedBy)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureRole(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Role>(builder);

            builder.Entity<Role>()
                .Property(x => x.Type)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureDepartment(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Department>(builder);

            builder.Entity<Department>()
                .Property(x => x.Title)
                .IsRequired();           

            return builder;
        }

        private ModelBuilder ConfigureEmployee(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Employee>(builder);

            builder.Entity<Employee>()
                .Property(x => x.Email)
                .IsRequired();

            builder.Entity<Employee>()
                .Property(x => x.Password)
                .IsRequired();

            builder.Entity<Employee>()
                .Property(x => x.Firstname)
                .IsRequired();

            builder.Entity<Employee>()
                .Property(x => x.Lastname)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureAddress(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Address>(builder);

            builder.Entity<Address>()
                .Property(x => x.Street)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureWarehouse(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Warehouse>(builder);

            builder.Entity<Warehouse>()
                .Property(x => x.Name)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureShelf(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Shelf>(builder);

            builder.Entity<Shelf>()
                .Property(x => x.Designation)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureCompartment(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Compartment>(builder);

            builder.Entity<Compartment>()
                .Property(x => x.Row)
                .IsRequired();

            builder.Entity<Compartment>()
                .Property(x => x.Column)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureProduct(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Product>(builder);

            builder.Entity<Product>()
               .Property(x => x.Name)
               .IsRequired();                              

            builder.Entity<Product>()
              .Property(x => x.SerialNumber)
              .IsRequired();

            builder.Entity<Product>()
                .Property(x => x.State)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureBusinessPartner(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<BusinessPartner>(builder);

            builder.Entity<BusinessPartner>()
                .Property(x => x.Name)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureBusinessContact(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<BusinessContact>(builder);

            builder.Entity<BusinessContact>()
                .Property(x => x.Firstname)
                .IsRequired();

            builder.Entity<BusinessContact>()
                .Property(x => x.Lastname)
                .IsRequired();            

            builder.Entity<BusinessContact>()
                .Property(x => x.Email)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureCountry(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Country>(builder);

            // Set length of abbrevation to 3
            builder.Entity<Country>()
                .Property(x => x.Abbreviation)
                .HasMaxLength(3)
                .IsFixedLength(true)
                .IsRequired();

            builder.Entity<Country>()
                .Property(x => x.Name)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureCity(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<City>(builder);

            builder.Entity<City>()
                .Property(x => x.Name)
                .IsRequired();

            builder.Entity<City>()
                .Property(x => x.PostalCode)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureProductType(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<ProductType>(builder);

            builder.Entity<ProductType>()
              .Property(x => x.EAN)
              .IsRequired();

            builder.Entity<ProductType>()
                .Property(x => x.Name)
                .IsRequired();

            builder.Entity<ProductType>()
                .Property(x => x.Price)
                .HasColumnType("decimal(18,2)") // specify precision and scale of decimal for Db
                .IsRequired();

            return builder;
        }

        /// <summary>
        /// Configure method for all entities wich inherit from <see cref="LogEntry"/>
        /// </summary>
        /// <typeparam name="TLog">Type of derived class</typeparam>
        /// <param name="builder">current <see cref="ModelBuilder"/> instance</param>
        private ModelBuilder ConfigureLogEntry<TLog>(ModelBuilder builder) where TLog : LogEntry
        {
            builder = ConfigureBaseFields<TLog>(builder);

            builder.Entity<TLog>()
                .Property(x => x.LogMessage)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureOrder(ModelBuilder builder)
        {
            builder = ConfigureBaseFields<Order>(builder);

            builder.Entity<Order>()
                .Property(x => x.Date)
                .IsRequired();

            builder.Entity<Order>()
                .Property(x => x.State)
                .IsRequired();

            builder.Entity<Order>()
                .Property(x => x.TotalPrice)
                .HasColumnType("decimal(18,2)") // specify precision and scale of decimal for Db
                .IsRequired();

            return builder;
        }

        #endregion
    }
}
