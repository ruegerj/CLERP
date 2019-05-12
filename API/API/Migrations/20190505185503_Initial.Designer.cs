﻿// <auto-generated />
using System;
using CLERP.API.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CLERP.API.Migrations
{
    [DbContext(typeof(ClerpContext))]
    [Migration("20190505185503_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CLERP.API.Domain.Models.Address", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("BusinessPartnerGuid");

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

            modelBuilder.Entity("CLERP.API.Domain.Models.Bill", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.BusinessContact", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.BusinessPartner", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.City", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Compartment", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.ContactLog", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Country", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Department", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Employee", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DepartmentGuid");

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

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.ProductTypeOrder", b =>
                {
                    b.Property<Guid>("ProductTypeGuid");

                    b.Property<Guid>("OrderGuid");

                    b.HasKey("ProductTypeGuid", "OrderGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("OrderGuid");

                    b.ToTable("Product-Types_Orders");
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.ProductTypeProductType", b =>
                {
                    b.Property<Guid>("ParentGuid");

                    b.Property<Guid>("ChildGuid");

                    b.HasKey("ParentGuid", "ChildGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("ChildGuid");

                    b.ToTable("Product-Types_Product-Types");
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.RoleDepartment", b =>
                {
                    b.Property<Guid>("RoleGuid");

                    b.Property<Guid>("DepartmentGuid");

                    b.HasKey("RoleGuid", "DepartmentGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("DepartmentGuid");

                    b.ToTable("Roles_Departments");
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.RoleEmployee", b =>
                {
                    b.Property<Guid>("RoleGuid");

                    b.Property<Guid>("EmployeeGuid");

                    b.HasKey("RoleGuid", "EmployeeGuid")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("EmployeeGuid");

                    b.ToTable("Roley_Employees");
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

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

            modelBuilder.Entity("CLERP.API.Domain.Models.PartnerLog", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("BillGuid");

                    b.Property<Guid>("CompartmentGuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<byte[]>("Image");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate();

                    b.Property<string>("LastModifiedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<Guid?>("ParentGuid");

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

            modelBuilder.Entity("CLERP.API.Domain.Models.ProductType", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Role", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Shelf", b =>
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

            modelBuilder.Entity("CLERP.API.Domain.Models.Warehouse", b =>
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

                    b.HasIndex("AddressGuid");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Address", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.BusinessPartner", "BusinessPartner")
                        .WithMany("Addresses")
                        .HasForeignKey("BusinessPartnerGuid");

                    b.HasOne("CLERP.API.Domain.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Bill", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Order", "Order")
                        .WithMany("Bills")
                        .HasForeignKey("OrderGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.BusinessContact", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.BusinessPartner", "BusinessPartner")
                        .WithMany("Contacts")
                        .HasForeignKey("BusinessPartnerGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.City", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Compartment", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Shelf", "Shelf")
                        .WithMany("Compartments")
                        .HasForeignKey("ShelfGuid");
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.ContactLog", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.BusinessContact", "Contact")
                        .WithMany("Logs")
                        .HasForeignKey("ContactGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Employee", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentGuid");
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.ProductTypeOrder", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Order", "Order")
                        .WithMany("ProductTypes")
                        .HasForeignKey("OrderGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.API.Domain.Models.ProductType", "ProductType")
                        .WithMany("Orders")
                        .HasForeignKey("ProductTypeGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.ProductTypeProductType", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.ProductType", "Child")
                        .WithMany("Parents")
                        .HasForeignKey("ChildGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.API.Domain.Models.ProductType", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.RoleDepartment", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Department", "Department")
                        .WithMany("Roles")
                        .HasForeignKey("DepartmentGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.API.Domain.Models.Role", "Role")
                        .WithMany("Departments")
                        .HasForeignKey("RoleGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Link.RoleEmployee", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Employee", "Employee")
                        .WithMany("Roles")
                        .HasForeignKey("EmployeeGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.API.Domain.Models.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Order", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Address", "BillingAddress")
                        .WithMany("BillingOrders")
                        .HasForeignKey("BillingAddressGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.API.Domain.Models.BusinessPartner", "ReceivingPartner")
                        .WithMany("ReceivedOrders")
                        .HasForeignKey("ReceivingPartnerGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.API.Domain.Models.BusinessPartner", "SendingPartner")
                        .WithMany("SendtOrders")
                        .HasForeignKey("SendingPartnerGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.API.Domain.Models.Address", "ShippingAddress")
                        .WithMany("ShippingOrders")
                        .HasForeignKey("ShippingAddressGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.PartnerLog", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.BusinessPartner", "Partner")
                        .WithMany("Logs")
                        .HasForeignKey("PartnerGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Product", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Bill", "Bill")
                        .WithMany("ProductsToPay")
                        .HasForeignKey("BillGuid");

                    b.HasOne("CLERP.API.Domain.Models.Compartment", "Compartment")
                        .WithMany("Products")
                        .HasForeignKey("CompartmentGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CLERP.API.Domain.Models.Product", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CLERP.API.Domain.Models.ProductType", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Shelf", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Warehouse", "Warehouse")
                        .WithMany("Shelves")
                        .HasForeignKey("WarehouseGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CLERP.API.Domain.Models.Warehouse", b =>
                {
                    b.HasOne("CLERP.API.Domain.Models.Address", "Address")
                        .WithMany("Warehouses")
                        .HasForeignKey("AddressGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
