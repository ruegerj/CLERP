﻿// <auto-generated />
using System;
using CLERP.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CLERP.DataAccess.Migrations
{
    [DbContext(typeof(ClerpContext))]
    [Migration("20190430173712_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CLERP.Business.Models.Address", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("BusinessPartnerGuid");

                    b.Property<Guid>("CityGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Housenumber");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.HasIndex("BusinessPartnerGuid");

                    b.HasIndex("CityGuid");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CLERP.Business.Models.Bill", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("AdditionalDeadlineDays");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<Guid>("OrderGuid");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ValidFrom");

                    b.HasKey("Guid");

                    b.HasIndex("OrderGuid")
                        .IsUnique();

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("CLERP.Business.Models.BusinessContact", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("BusinessPartnerGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Firstname")
                        .IsRequired();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Lastname")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Guid");

                    b.HasIndex("BusinessPartnerGuid");

                    b.ToTable("Business-Contacts");
                });

            modelBuilder.Entity("CLERP.Business.Models.BusinessPartner", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.ToTable("Business-Partners");
                });

            modelBuilder.Entity("CLERP.Business.Models.City", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("CountryGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PostalCode");

                    b.HasKey("Guid");

                    b.HasIndex("CountryGuid");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CLERP.Business.Models.Compartment", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("Column");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<int>("Row");

                    b.Property<Guid?>("ShelfGuid");

                    b.HasKey("Guid");

                    b.HasIndex("ShelfGuid");

                    b.ToTable("Compartments");
                });

            modelBuilder.Entity("CLERP.Business.Models.ContactLog", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("ContactGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("LogMessage")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.HasIndex("ContactGuid");

                    b.ToTable("Business-Contact-Logs");
                });

            modelBuilder.Entity("CLERP.Business.Models.Country", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(3);

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CLERP.Business.Models.Department", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CLERP.Business.Models.Employee", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DepartmentGuid");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Firstname")
                        .IsRequired();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Lastname")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Salt")
                        .IsRequired();

                    b.Property<string>("Username");

                    b.HasKey("Guid");

                    b.HasIndex("DepartmentGuid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.ProductTypeOrder", b =>
                {
                    b.Property<Guid>("ProductTypeGuid");

                    b.Property<Guid>("OrderGuid");

                    b.HasKey("ProductTypeGuid", "OrderGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("OrderGuid");

                    b.ToTable("Product-Types_Orders");
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.ProductTypeProductType", b =>
                {
                    b.Property<Guid>("ParentGuid");

                    b.Property<Guid>("ChildGuid");

                    b.HasKey("ParentGuid", "ChildGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("ChildGuid");

                    b.ToTable("Product-Types_Product-Types");
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.RoleDepartment", b =>
                {
                    b.Property<Guid>("RoleGuid");

                    b.Property<Guid>("DepartmentGuid");

                    b.HasKey("RoleGuid", "DepartmentGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("DepartmentGuid");

                    b.ToTable("Roles_Departments");
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.RoleEmployee", b =>
                {
                    b.Property<Guid>("RoleGuid");

                    b.Property<Guid>("EmployeeGuid");

                    b.HasKey("RoleGuid", "EmployeeGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("EmployeeGuid");

                    b.ToTable("Roley_Employees");
                });

            modelBuilder.Entity("CLERP.Business.Models.Order", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("BillGuid");

                    b.Property<Guid>("BillingAddressGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("EstimatedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<Guid>("ReceivingPartnerGuid");

                    b.Property<DateTime>("SendDate");

                    b.Property<Guid>("SendingPartnerGuid");

                    b.Property<Guid>("ShippingAddressGuid");

                    b.Property<string>("State")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.HasIndex("BillingAddressGuid");

                    b.HasIndex("ReceivingPartnerGuid");

                    b.HasIndex("SendingPartnerGuid");

                    b.HasIndex("ShippingAddressGuid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CLERP.Business.Models.PartnerLog", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("LogMessage")
                        .IsRequired();

                    b.Property<Guid>("PartnerGuid");

                    b.HasKey("Guid");

                    b.HasIndex("PartnerGuid");

                    b.ToTable("Business-Partner-Logs");
                });

            modelBuilder.Entity("CLERP.Business.Models.Product", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("BillGuid");

                    b.Property<Guid>("CompartmentGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<Guid>("ParentGuid");

                    b.Property<string>("SerialNumber")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<Guid>("TypeGuid");

                    b.HasKey("Guid");

                    b.HasIndex("BillGuid");

                    b.HasIndex("CompartmentGuid");

                    b.HasIndex("ParentGuid");

                    b.HasIndex("TypeGuid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CLERP.Business.Models.ProductType", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("EAN")
                        .IsRequired();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Guid");

                    b.ToTable("Product-Types");
                });

            modelBuilder.Entity("CLERP.Business.Models.Role", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CLERP.Business.Models.Shelf", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Designation")
                        .IsRequired();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<Guid>("WarehouseGuid");

                    b.HasKey("Guid");

                    b.HasIndex("WarehouseGuid");

                    b.ToTable("Shelves");
                });

            modelBuilder.Entity("CLERP.Business.Models.Warehouse", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("AddressGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Guid");

                    b.HasIndex("AddressGuid")
                        .IsUnique();

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("CLERP.Business.Models.Address", b =>
                {
                    b.HasOne("CLERP.Business.Models.BusinessPartner", "BusinessPartner")
                        .WithMany("Addresses")
                        .HasForeignKey("BusinessPartnerGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.Business.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Bill", b =>
                {
                    b.HasOne("CLERP.Business.Models.Order", "Order")
                        .WithOne("Bill")
                        .HasForeignKey("CLERP.Business.Models.Bill", "OrderGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CLERP.Business.Models.BusinessContact", b =>
                {
                    b.HasOne("CLERP.Business.Models.BusinessPartner", "BusinessPartner")
                        .WithMany("Contacts")
                        .HasForeignKey("BusinessPartnerGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.City", b =>
                {
                    b.HasOne("CLERP.Business.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Compartment", b =>
                {
                    b.HasOne("CLERP.Business.Models.Shelf", "Shelf")
                        .WithMany("Compartments")
                        .HasForeignKey("ShelfGuid");
                });

            modelBuilder.Entity("CLERP.Business.Models.ContactLog", b =>
                {
                    b.HasOne("CLERP.Business.Models.BusinessContact", "Contact")
                        .WithMany("Logs")
                        .HasForeignKey("ContactGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Employee", b =>
                {
                    b.HasOne("CLERP.Business.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.ProductTypeOrder", b =>
                {
                    b.HasOne("CLERP.Business.Models.Order", "Order")
                        .WithMany("ProductTypes")
                        .HasForeignKey("OrderGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.Business.Models.ProductType", "ProductType")
                        .WithMany("Orders")
                        .HasForeignKey("ProductTypeGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.ProductTypeProductType", b =>
                {
                    b.HasOne("CLERP.Business.Models.ProductType", "Child")
                        .WithMany("Parents")
                        .HasForeignKey("ChildGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.Business.Models.ProductType", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.RoleDepartment", b =>
                {
                    b.HasOne("CLERP.Business.Models.Department", "Department")
                        .WithMany("Roles")
                        .HasForeignKey("DepartmentGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.Business.Models.Role", "Role")
                        .WithMany("Departments")
                        .HasForeignKey("RoleGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Link.RoleEmployee", b =>
                {
                    b.HasOne("CLERP.Business.Models.Employee", "Employee")
                        .WithMany("Roles")
                        .HasForeignKey("EmployeeGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.Business.Models.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Order", b =>
                {
                    b.HasOne("CLERP.Business.Models.Address", "BillingAddress")
                        .WithMany("BillingOrders")
                        .HasForeignKey("BillingAddressGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.Business.Models.BusinessPartner", "ReceivingPartner")
                        .WithMany("ReceivedOrders")
                        .HasForeignKey("ReceivingPartnerGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.Business.Models.BusinessPartner", "SendingPartner")
                        .WithMany("SendtOrders")
                        .HasForeignKey("SendingPartnerGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.Business.Models.Address", "ShippingAddress")
                        .WithMany("ShippingOrders")
                        .HasForeignKey("ShippingAddressGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CLERP.Business.Models.PartnerLog", b =>
                {
                    b.HasOne("CLERP.Business.Models.BusinessPartner", "Partner")
                        .WithMany("Logs")
                        .HasForeignKey("PartnerGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Product", b =>
                {
                    b.HasOne("CLERP.Business.Models.Bill", "Bill")
                        .WithMany("ProductsToPay")
                        .HasForeignKey("BillGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.Business.Models.Compartment", "Compartment")
                        .WithMany("Products")
                        .HasForeignKey("CompartmentGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.Business.Models.Product", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.Business.Models.ProductType", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Shelf", b =>
                {
                    b.HasOne("CLERP.Business.Models.Warehouse", "Warehouse")
                        .WithMany("Shelves")
                        .HasForeignKey("WarehouseGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.Business.Models.Warehouse", b =>
                {
                    b.HasOne("CLERP.Business.Models.Address", "Address")
                        .WithOne("Warehouse")
                        .HasForeignKey("CLERP.Business.Models.Warehouse", "AddressGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}