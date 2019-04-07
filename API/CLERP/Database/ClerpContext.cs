using CLERP.Database.Entities;
using CLERP.Database.Entities.Abstract;
using CLERP.Database.Entities.Link;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
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
        /// <param name="builder">current <see cref="ModelBuilder"/> instance</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Table renaming

            builder.Entity<Role>()
                .ToTable(nameof(Roles).ToLower());

            builder.Entity<Department>()
                .ToTable(nameof(Departments).ToLower());

            builder.Entity<Employee>()
                .ToTable(nameof(Employees).ToLower());

            builder.Entity<Adress>()
                .ToTable(nameof(Adresses).ToLower());

            builder.Entity<Warehouse>()
                .ToTable(nameof(Warehouses).ToLower());

            builder.Entity<Shelf>()
                .ToTable(nameof(Shelves).ToLower());

            builder.Entity<Compartment>()
                .ToTable(nameof(Compartments).ToLower());

            builder.Entity<Product>()
                .ToTable(nameof(Products).ToLower());

            builder.Entity<BusinessPartner>()
                .ToTable("business-partners");

            builder.Entity<BusinessContact>()
                .ToTable("business-contacts");

            builder.Entity<RoleDepartment>()
                .ToTable("roles_departments");

            builder.Entity<RoleEmployee>()
                .ToTable("roles_employees");

            #endregion

            #region Table configurations            

            builder = ConfigureRole(builder);

            builder = ConfigureDepartment(builder);

            builder = ConfigureEmployee(builder);

            builder = ConfigureAdress(builder);

            builder = ConfigureWarehouse(builder);

            builder = ConfigureShelf(builder);

            builder = ConfigureCompartment(builder);

            builder = ConfigureProduct(builder);

            builder = ConfigureBusinessPartner(builder);

            #endregion

            #region Table relations

            // Role <-> Department
            builder.Entity<RoleDepartment>()
                .HasKey(x => new { x.RoleId, x.DepartmentId });

            builder.Entity<RoleDepartment>()
                .HasOne(x => x.Role)
                .WithMany(y => y.Departments)
                .HasForeignKey(y => y.DepartmentId);

            builder.Entity<RoleDepartment>()
                .HasOne(x => x.Department)
                .WithMany(y => y.Roles)
                .HasForeignKey(y => y.RoleId);

            // Role <-> Employee
            builder.Entity<RoleEmployee>()
                .HasKey(x => new { x.RoleId, x.EmployeeId });

            builder.Entity<RoleEmployee>()
                .HasOne(x => x.Role)
                .WithMany(y => y.Employees)
                .HasForeignKey(y => y.EmployeeId);

            builder.Entity<RoleEmployee>()
                .HasOne(x => x.Employee)
                .WithMany(y => y.Roles)
                .HasForeignKey(y => y.RoleId);

            // Product(Parent) -> Prodcut(Child)
            builder.Entity<Product>()
                .HasOne(x => x.Parent)
                .WithMany(x => x.Children)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Value Converters

            var roleTypeConverter = new ValueConverter<RoleType, string>(
                v => v.ToString(), // value -> Db
                v => (RoleType)Enum.Parse(typeof(RoleType), v)); // value <- Db

            builder.Entity<Role>()
                .Property(x => x.Type)
                .HasConversion(roleTypeConverter);

            #endregion
        }

        
        // Ordinary Tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Compartment> Compartments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BusinessPartner> BusinessPartners { get; set; }
        public DbSet<BusinessContact> BusinessContacts { get; set; }

        // Link-Tables
        public DbSet<RoleEmployee> RolesEmployees { get; set; }
        public DbSet<RoleDepartment> RolesDepartments { get; set; }

        #region Configurators for entities

        private ModelBuilder ConfigureRole(ModelBuilder builder)
        {
            builder.Entity<Role>()
                .HasKey(x => x.Id);

            builder.Entity<Role>()
                .Property(x => x.Creation)                
                .IsRequired();

            builder.Entity<Role>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<Role>()
                .Property(x => x.Type)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureDepartment(ModelBuilder builder)
        {
            builder.Entity<Department>()
                .HasKey(x => x.Id);

            builder.Entity<Department>()
                .Property(x => x.Title)
                .IsRequired();

            builder.Entity<Department>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<Department>()
                .Property(x => x.LastModified)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureEmployee(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                .HasKey(x => x.Id);

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

            builder.Entity<Employee>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<Employee>()
                .Property(x => x.LastModified)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureAdress(ModelBuilder builder)
        {
            builder.Entity<Adress>()
              .HasKey(x => x.Id);

            builder.Entity<Adress>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<Adress>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<Adress>()
                .Property(x => x.PostalCode)
                .IsRequired();

            builder.Entity<Adress>()
                .Property(x => x.Street)
                .IsRequired();

            builder.Entity<Adress>()
                .Property(x => x.City)
                .IsRequired();

            builder.Entity<Adress>()
                .Property(x => x.Country)
                .IsRequired();

            builder.Entity<Adress>()
                .Property(x => x.CountryAbbreviation)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureWarehouse(ModelBuilder builder)
        {
            builder.Entity<Warehouse>()
                .HasKey(x => x.Id);

            builder.Entity<Warehouse>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<Warehouse>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<Warehouse>()
                .Property(x => x.Name)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureShelf(ModelBuilder builder)
        {
            builder.Entity<Shelf>()
                .HasKey(x => x.Id);

            builder.Entity<Shelf>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<Shelf>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<Shelf>()
                .Property(x => x.Designation)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureCompartment(ModelBuilder builder)
        {
            builder.Entity<Compartment>()
                .HasKey(x => x.Id);

            builder.Entity<Compartment>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<Compartment>()
                .Property(x => x.LastModified)
                .IsRequired();

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
            builder.Entity<Product>()
                .HasKey(x => x.Id);

            builder.Entity<Product>()
               .Property(x => x.Creation)
               .IsRequired();

            builder.Entity<Product>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<Product>()
               .Property(x => x.Name)
               .IsRequired();

            builder.Entity<Product>()
                .Property(x => x.Price)
                .HasColumnType<decimal>("decimal(18,2)") // specify precision and scale of decimal for Db
                .IsRequired();                         

            builder.Entity<Product>()
              .Property(x => x.SerialNumber)
              .IsRequired();

            builder.Entity<Product>()
              .Property(x => x.EAN)
              .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureBusinessPartner(ModelBuilder builder)
        {
            builder.Entity<BusinessPartner>()
                .HasKey(x => x.Id);

            builder.Entity<BusinessPartner>()
               .Property(x => x.Creation)
               .IsRequired();

            builder.Entity<BusinessPartner>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<BusinessPartner>()
                .Property(x => x.Name)
                .IsRequired();

            return builder;
        }

        private ModelBuilder ConfigureBusinessContact(ModelBuilder builder)
        {
            builder.Entity<BusinessContact>()
                .HasKey(x => x.Id);

            builder.Entity<BusinessContact>()
                .Property(x => x.Firstname)
                .IsRequired();

            builder.Entity<BusinessContact>()
                .Property(x => x.Lastname)
                .IsRequired();

            builder.Entity<BusinessContact>()
                .Property(x => x.Creation)
                .IsRequired();

            builder.Entity<BusinessContact>()
                .Property(x => x.LastModified)
                .IsRequired();

            builder.Entity<BusinessContact>()
                .Property(x => x.Email)
                .IsRequired();

            return builder;
        }

        #endregion
    }

}
