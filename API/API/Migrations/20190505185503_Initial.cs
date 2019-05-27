using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CLERP.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business-Partners",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business-Partners", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Abbreviation = table.Column<string>(fixedLength: true, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Product-Types",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EAN = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product-Types", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Business-Contacts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    BusinessPartnerGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business-Contacts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Business-Contacts_Business-Partners_BusinessPartnerGuid",
                        column: x => x.BusinessPartnerGuid,
                        principalTable: "Business-Partners",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Business-Partner-Logs",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    LogMessage = table.Column<string>(nullable: false),
                    PartnerGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business-Partner-Logs", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Business-Partner-Logs_Business-Partners_PartnerGuid",
                        column: x => x.PartnerGuid,
                        principalTable: "Business-Partners",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    CountryGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryGuid",
                        column: x => x.CountryGuid,
                        principalTable: "Countries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    Salt = table.Column<string>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    DepartmentGuid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentGuid",
                        column: x => x.DepartmentGuid,
                        principalTable: "Departments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product-Types_Product-Types",
                columns: table => new
                {
                    ParentGuid = table.Column<Guid>(nullable: false),
                    ChildGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product-Types_Product-Types", x => new { x.ParentGuid, x.ChildGuid })
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Product-Types_Product-Types_Product-Types_ChildGuid",
                        column: x => x.ChildGuid,
                        principalTable: "Product-Types",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product-Types_Product-Types_Product-Types_ParentGuid",
                        column: x => x.ParentGuid,
                        principalTable: "Product-Types",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles_Departments",
                columns: table => new
                {
                    RoleGuid = table.Column<Guid>(nullable: false),
                    DepartmentGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles_Departments", x => new { x.RoleGuid, x.DepartmentGuid })
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Roles_Departments_Departments_DepartmentGuid",
                        column: x => x.DepartmentGuid,
                        principalTable: "Departments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roles_Departments_Roles_RoleGuid",
                        column: x => x.RoleGuid,
                        principalTable: "Roles",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Business-Contact-Logs",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    LogMessage = table.Column<string>(nullable: false),
                    ContactGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business-Contact-Logs", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Business-Contact-Logs_Business-Contacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "Business-Contacts",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Housenumber = table.Column<int>(nullable: true),
                    CityGuid = table.Column<Guid>(nullable: false),
                    BusinessPartnerGuid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Addresses_Business-Partners_BusinessPartnerGuid",
                        column: x => x.BusinessPartnerGuid,
                        principalTable: "Business-Partners",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityGuid",
                        column: x => x.CityGuid,
                        principalTable: "Cities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roley_Employees",
                columns: table => new
                {
                    RoleGuid = table.Column<Guid>(nullable: false),
                    EmployeeGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roley_Employees", x => new { x.RoleGuid, x.EmployeeGuid })
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Roley_Employees_Employees_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roley_Employees_Roles_RoleGuid",
                        column: x => x.RoleGuid,
                        principalTable: "Roles",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    SendDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: false),
                    EstimatedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SendingPartnerGuid = table.Column<Guid>(nullable: false),
                    ReceivingPartnerGuid = table.Column<Guid>(nullable: false),
                    ShippingAddressGuid = table.Column<Guid>(nullable: false),
                    BillingAddressGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_BillingAddressGuid",
                        column: x => x.BillingAddressGuid,
                        principalTable: "Addresses",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Business-Partners_ReceivingPartnerGuid",
                        column: x => x.ReceivingPartnerGuid,
                        principalTable: "Business-Partners",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Business-Partners_SendingPartnerGuid",
                        column: x => x.SendingPartnerGuid,
                        principalTable: "Business-Partners",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_ShippingAddressGuid",
                        column: x => x.ShippingAddressGuid,
                        principalTable: "Addresses",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    AddressGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Warehouses_Addresses_AddressGuid",
                        column: x => x.AddressGuid,
                        principalTable: "Addresses",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    AdditionalDeadlineDays = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    OrderGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Bills_Orders_OrderGuid",
                        column: x => x.OrderGuid,
                        principalTable: "Orders",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product-Types_Orders",
                columns: table => new
                {
                    ProductTypeGuid = table.Column<Guid>(nullable: false),
                    OrderGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product-Types_Orders", x => new { x.ProductTypeGuid, x.OrderGuid })
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Product-Types_Orders_Orders_OrderGuid",
                        column: x => x.OrderGuid,
                        principalTable: "Orders",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product-Types_Orders_Product-Types_ProductTypeGuid",
                        column: x => x.ProductTypeGuid,
                        principalTable: "Product-Types",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    WarehouseGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Shelves_Warehouses_WarehouseGuid",
                        column: x => x.WarehouseGuid,
                        principalTable: "Warehouses",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compartments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Row = table.Column<int>(nullable: false),
                    Column = table.Column<int>(nullable: false),
                    ShelfGuid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compartments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Compartments_Shelves_ShelfGuid",
                        column: x => x.ShelfGuid,
                        principalTable: "Shelves",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Creation = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    ParentGuid = table.Column<Guid>(nullable: true),
                    TypeGuid = table.Column<Guid>(nullable: false),
                    CompartmentGuid = table.Column<Guid>(nullable: false),
                    BillGuid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Products_Bills_BillGuid",
                        column: x => x.BillGuid,
                        principalTable: "Bills",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Compartments_CompartmentGuid",
                        column: x => x.CompartmentGuid,
                        principalTable: "Compartments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Products_ParentGuid",
                        column: x => x.ParentGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Product-Types_TypeGuid",
                        column: x => x.TypeGuid,
                        principalTable: "Product-Types",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_BusinessPartnerGuid",
                table: "Addresses",
                column: "BusinessPartnerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityGuid",
                table: "Addresses",
                column: "CityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OrderGuid",
                table: "Bills",
                column: "OrderGuid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Business-Contact-Logs_ContactGuid",
                table: "Business-Contact-Logs",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Business-Contacts_BusinessPartnerGuid",
                table: "Business-Contacts",
                column: "BusinessPartnerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Business-Partner-Logs_PartnerGuid",
                table: "Business-Partner-Logs",
                column: "PartnerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryGuid",
                table: "Cities",
                column: "CountryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Compartments_ShelfGuid",
                table: "Compartments",
                column: "ShelfGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentGuid",
                table: "Employees",
                column: "DepartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressGuid",
                table: "Orders",
                column: "BillingAddressGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ReceivingPartnerGuid",
                table: "Orders",
                column: "ReceivingPartnerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SendingPartnerGuid",
                table: "Orders",
                column: "SendingPartnerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressGuid",
                table: "Orders",
                column: "ShippingAddressGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BillGuid",
                table: "Products",
                column: "BillGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompartmentGuid",
                table: "Products",
                column: "CompartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ParentGuid",
                table: "Products",
                column: "ParentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeGuid",
                table: "Products",
                column: "TypeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Product-Types_Orders_OrderGuid",
                table: "Product-Types_Orders",
                column: "OrderGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Product-Types_Product-Types_ChildGuid",
                table: "Product-Types_Product-Types",
                column: "ChildGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Departments_DepartmentGuid",
                table: "Roles_Departments",
                column: "DepartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Roley_Employees_EmployeeGuid",
                table: "Roley_Employees",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_WarehouseGuid",
                table: "Shelves",
                column: "WarehouseGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressGuid",
                table: "Warehouses",
                column: "AddressGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business-Contact-Logs");

            migrationBuilder.DropTable(
                name: "Business-Partner-Logs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Product-Types_Orders");

            migrationBuilder.DropTable(
                name: "Product-Types_Product-Types");

            migrationBuilder.DropTable(
                name: "Roles_Departments");

            migrationBuilder.DropTable(
                name: "Roley_Employees");

            migrationBuilder.DropTable(
                name: "Business-Contacts");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Compartments");

            migrationBuilder.DropTable(
                name: "Product-Types");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Shelves");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Business-Partners");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
