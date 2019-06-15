using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class AddedSeedDataForCountryCityAdressWarehouseShelvesCompartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compartments_Shelves_ShelfGuid",
                table: "Compartments");

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), new Guid("273a60ce-7282-4141-9676-1c3040ec1303") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("65231084-3178-4259-886c-4698a02c701d"), new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), new Guid("426a9547-086d-4847-a80e-00140da99723") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af") });

            migrationBuilder.DeleteData(
                table: "Roles_Employees",
                keyColumns: new[] { "RoleGuid", "EmployeeGuid" },
                keyValues: new object[] { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf") });

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("273a60ce-7282-4141-9676-1c3040ec1303"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("426a9547-086d-4847-a80e-00140da99723"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Guid",
                keyValue: new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("65231084-3178-4259-886c-4698a02c701d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ShelfGuid",
                table: "Compartments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Guid", "Abbreviation", "CreatedBy", "Creation", "LastModified", "LastModifiedBy", "Name" },
                values: new object[] { new Guid("0906d22f-39c2-4619-8c5b-1ba73db80f64"), "CH", "system", new DateTime(2019, 6, 15, 15, 20, 43, 204, DateTimeKind.Local).AddTicks(7481), new DateTime(2019, 6, 15, 15, 20, 43, 204, DateTimeKind.Local).AddTicks(7552), "system", "Switzerland" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(1434), "The management of the firm", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(1533), "system", "Management" },
                    { new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4301), "The finance department of the firm", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4324), "system", "Finance" },
                    { new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4374), "The hr department of the firm", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4379), "system", "HR" },
                    { new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4395), "The sales department of the firm", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4399), "system", "Sales" },
                    { new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4412), "The purchase department of the firm", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4416), "system", "Purchase" },
                    { new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4442), "The logistics department of the firm", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4445), "system", "Logistic" },
                    { new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4459), "The production department of the firm", new DateTime(2019, 6, 15, 15, 20, 43, 214, DateTimeKind.Local).AddTicks(4463), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(2725), "Employee from the logistics department", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(2771), "system", "Logistic" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4125), "Employee from the finances department", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4135), "system", "Finance" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4159), "Employee from the purchases department", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4163), "system", "Purchase" },
                    { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4174), "Administrators of the app", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4177), "system", "SysAdmin" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4189), "Employee from the sales department", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4192), "system", "Sale" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4209), "Employee from the management", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4212), "system", "Management" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4221), "Employee from the hr department", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4224), "system", "HR" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4234), "Employee from the production department", new DateTime(2019, 6, 15, 15, 20, 43, 281, DateTimeKind.Local).AddTicks(4237), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Guid", "CountryGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy", "Name", "PostalCode" },
                values: new object[] { new Guid("7ac5c068-2194-40d2-8d78-95f6b8c62f4b"), new Guid("0906d22f-39c2-4619-8c5b-1ba73db80f64"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 174, DateTimeKind.Local).AddTicks(2383), new DateTime(2019, 6, 15, 15, 20, 43, 174, DateTimeKind.Local).AddTicks(2421), "sytem", "Zürich", 8000 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 15, 15, 20, 43, 224, DateTimeKind.Local).AddTicks(7702), new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "admin@clerp.ch", "System", new DateTime(2019, 6, 15, 15, 20, 43, 225, DateTimeKind.Local).AddTicks(1900), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles_Departments",
                columns: new[] { "RoleGuid", "DepartmentGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5857), new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5860), "system" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5744), new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5765), "system" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5834), new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5837), "system" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5815), new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5818), "system" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(3419), new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(4623), "system" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5792), new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5796), "system" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5875), new DateTime(2019, 6, 15, 15, 20, 43, 319, DateTimeKind.Local).AddTicks(5879), "system" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Guid", "BusinessPartnerGuid", "CityGuid", "CreatedBy", "Creation", "Housenumber", "LastModified", "LastModifiedBy", "Street" },
                values: new object[] { new Guid("3c3f2e8a-2ec3-45ea-8273-99e76d71190f"), null, new Guid("7ac5c068-2194-40d2-8d78-95f6b8c62f4b"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 126, DateTimeKind.Local).AddTicks(866), 5, new DateTime(2019, 6, 15, 15, 20, 43, 126, DateTimeKind.Local).AddTicks(2371), "system", "Lagerstrasse" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Guid", "BusinessPartnerGuid", "CityGuid", "CreatedBy", "Creation", "Housenumber", "LastModified", "LastModifiedBy", "Street" },
                values: new object[] { new Guid("5dd4e453-19a0-4cef-abfd-4cac78037490"), null, new Guid("7ac5c068-2194-40d2-8d78-95f6b8c62f4b"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 126, DateTimeKind.Local).AddTicks(7010), 7, new DateTime(2019, 6, 15, 15, 20, 43, 126, DateTimeKind.Local).AddTicks(7044), "system", "Lagerstrasse" });

            migrationBuilder.InsertData(
                table: "Roles_Employees",
                columns: new[] { "RoleGuid", "EmployeeGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 324, DateTimeKind.Local).AddTicks(1816), new DateTime(2019, 6, 15, 15, 20, 43, 324, DateTimeKind.Local).AddTicks(1841), "system" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Guid", "AddressGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy", "Name" },
                values: new object[] { new Guid("45b9b2e3-3fd7-4000-950a-781241c33656"), new Guid("3c3f2e8a-2ec3-45ea-8273-99e76d71190f"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 299, DateTimeKind.Local).AddTicks(5838), new DateTime(2019, 6, 15, 15, 20, 43, 299, DateTimeKind.Local).AddTicks(5873), "system", "Storage House 1" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Guid", "AddressGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy", "Name" },
                values: new object[] { new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab"), new Guid("5dd4e453-19a0-4cef-abfd-4cac78037490"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 299, DateTimeKind.Local).AddTicks(6271), new DateTime(2019, 6, 15, 15, 20, 43, 299, DateTimeKind.Local).AddTicks(6276), "system", "Storage House 2" });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Designation", "LastModified", "LastModifiedBy", "WarehouseGuid" },
                values: new object[,]
                {
                    { new Guid("28b762f2-9c41-4c0c-8546-5953861674e6"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(6983), "1A", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(7074), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8687), "3B", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8690), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8677), "3A", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8680), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8669), "2C", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8672), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("936c889e-d905-476b-960a-41f0b7a81f6f"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8661), "2B", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8664), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8652), "2A", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8655), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8643), "1C", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8646), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8635), "1B", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8638), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8626), "1A", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8629), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8612), "3D", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8615), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8603), "3C", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8606), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8593), "3B", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8597), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8584), "3A", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8587), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8575), "2C", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8578), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8558), "2B", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8561), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8549), "2A", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8552), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("354f67f3-faf9-4481-aa0e-497fac62213f"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8539), "1C", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8542), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8506), "1B", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8519), "system", new Guid("45b9b2e3-3fd7-4000-950a-781241c33656") },
                    { new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8696), "3C", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8699), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") },
                    { new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3"), "system", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8704), "3D", new DateTime(2019, 6, 15, 15, 20, 43, 291, DateTimeKind.Local).AddTicks(8707), "system", new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab") }
                });

            migrationBuilder.InsertData(
                table: "Compartments",
                columns: new[] { "Guid", "Column", "CreatedBy", "Creation", "LastModified", "LastModifiedBy", "Row", "ShelfGuid" },
                values: new object[,]
                {
                    { new Guid("abb6045d-8399-4ab8-a01f-342aff9ef97c"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(6117), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(6180), "system", 1, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("bad3fa7a-7601-43b4-8640-02edc286ea5b"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9052), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9055), "system", 2, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("fd3ac05d-e526-4228-80aa-45a07854ab12"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9060), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9063), "system", 2, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("c5714c92-0dab-48d1-8037-8a518a291970"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9075), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9078), "system", 2, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("54202658-d8cb-4e6b-ab55-df5f93724acc"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9086), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9089), "system", 1, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("6bd6b0db-f6ef-4938-8870-438b65560639"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9094), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9097), "system", 1, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("551cdf8b-a45b-4774-babf-0dad29198bac"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9102), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9105), "system", 1, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("657750aa-8dc5-4fe5-8c01-fef4126b5a1a"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9110), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9113), "system", 1, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("27968e60-1510-4eda-807c-2a9485906a81"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9118), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9122), "system", 1, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("f57ae8db-4a8b-4c77-9b32-fba1f72634a9"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9127), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9130), "system", 2, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("627122b2-37fb-4a4e-bd79-2c845cd2dbf3"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9135), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9138), "system", 2, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("2af20c16-5f32-47a9-9d02-9758fb5f5a84"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9144), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9147), "system", 2, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("6036338d-296b-4b70-8f86-3d3b4c698fce"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9152), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9155), "system", 2, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("3b10f4c9-14e1-4a59-99a5-a6ca8984d771"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9162), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9165), "system", 2, new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17") },
                    { new Guid("d9a55745-5576-40f0-af0e-eab4410d3649"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9171), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9174), "system", 1, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("008aa56b-3022-4387-b036-2572b6bb3cd7"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9179), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9182), "system", 1, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("515cd0cc-bf65-478e-b484-c73edffe5b05"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9188), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9191), "system", 1, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("2accfa6b-2930-4068-9f05-8481786d71e4"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9196), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9199), "system", 1, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("6b252adb-e3ce-492a-91d3-915a7af7485d"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9204), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9207), "system", 1, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("4fda7c05-4f9a-42d6-b6eb-97135ca6df26"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9213), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9216), "system", 2, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("41e82162-e790-4fab-85da-6d452a7b14c2"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9221), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9224), "system", 2, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("e1973445-0a84-4d2f-aa7f-78fcbf27fd8c"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9229), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9232), "system", 2, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("6f772471-e6ef-44d2-8aa5-94028ae806e8"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9044), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9047), "system", 2, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("3497b4b3-f2f5-4e0b-bda4-6939cc114db8"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9238), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9241), "system", 2, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("4d055871-7725-4e96-b9fb-5a695612e8c7"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9035), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9038), "system", 2, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("9a2b070d-2fd9-4433-8ccd-f8c51420f961"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8918), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8927), "system", 1, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("a3b01218-20f9-4910-8002-6c182cacae54"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8604), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8608), "system", 1, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("42dc0a36-7452-40d9-b209-3132a80cdd70"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8615), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8619), "system", 1, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("f8043cb7-123b-42ed-9d84-916327e51288"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8626), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8630), "system", 1, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("52335787-b378-4ade-a58a-71a9cbb81dfc"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8637), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8641), "system", 2, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("7f56412b-00cb-4f15-a810-f30e5a477724"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8648), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8652), "system", 2, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("ed013250-f02f-43a5-8ab5-b6d197159d20"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8658), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8662), "system", 2, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("f2dc1a47-e658-4f78-8117-a9acbfd416ce"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8668), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8672), "system", 2, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("acc497c3-c111-45ac-8f40-36b2b572d5b7"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8679), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8683), "system", 2, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("51dbbfe2-6982-44ba-b87b-1b6bb3ccfd9f"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8716), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8719), "system", 1, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("2fdccaae-0557-49ae-8397-31a20024cf59"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8726), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8730), "system", 1, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("f3710e61-316a-4324-8014-a091fbc97f0f"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8737), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8741), "system", 1, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("38424167-e621-4e79-b224-91fcf67f353c"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8747), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8751), "system", 1, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("29dfacec-8bbb-4606-9ffa-ec6ff0cd8c8b"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8758), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8762), "system", 1, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("a8df6e04-4852-4491-9a65-144dc4e9b414"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8769), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8773), "system", 2, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("a519a173-166b-460f-ae47-18e5f11ededf"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8781), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8785), "system", 2, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("92c7728b-d7bc-4e99-8d85-12102c21bd42"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8793), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8800), "system", 2, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("89da5de3-d9fe-4009-a972-9b4584845293"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8807), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8811), "system", 2, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("96991278-73ae-4bb9-9200-6769d7f991d7"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8819), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8823), "system", 2, new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483") },
                    { new Guid("5c44d385-dedd-4d65-b676-a901a50fc119"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8832), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8835), "system", 1, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("fc6ec2a2-af8e-4c27-95d3-7a46b9fa3e21"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8842), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8850), "system", 1, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("eaae9d52-c90e-4616-a4f6-b92ab0205c0b"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8868), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8875), "system", 1, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("c9f9b4dc-e5d9-466c-8a76-f8f4d74925a3"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9020), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9024), "system", 1, new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf") },
                    { new Guid("5113d883-c0f8-4b2b-b2b9-7b63f27cb75f"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8593), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8597), "system", 1, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("5da6ca7e-a856-41d9-934c-56d19020362f"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9246), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9249), "system", 2, new Guid("936c889e-d905-476b-960a-41f0b7a81f6f") },
                    { new Guid("cfb7d7ca-8fdb-4f0a-91a8-1659b9141d8b"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9263), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9266), "system", 1, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("187b66a4-ffcd-4552-99f5-44078991efa6"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9526), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9529), "system", 2, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("3f5fb9fe-e052-4ccc-9c55-cf05c6f31bae"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9535), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9538), "system", 2, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("19027aa6-d013-436e-864c-cd4e23104cc6"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9543), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9546), "system", 2, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("5ef487eb-cbe3-4f3a-ad88-39cfac44d0de"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9552), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9555), "system", 1, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("3bafb4db-f870-4540-9493-6b26387ec25a"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9561), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9564), "system", 1, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("35bb99c0-e353-469a-a28f-5af1aa31ae73"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9569), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9572), "system", 1, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("bdce802e-3f4f-4262-a3d6-420156a7e61b"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9577), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9580), "system", 1, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("18289f04-544e-4f02-b38b-1fcb0007e818"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9585), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9590), "system", 1, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("ba9f89b3-0add-4dd8-b365-7681ba3e7e2c"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9596), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9599), "system", 2, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("69368ac4-2784-4725-aa69-6f2caee201a0"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9604), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9607), "system", 2, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("8deaa195-ba88-416c-b257-199e9fe42335"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9612), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9615), "system", 2, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("4605d1de-e9ff-427e-97aa-4aad9d87a151"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9622), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9625), "system", 2, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("d5ef4118-a5d8-4713-8651-4815a239e91b"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9630), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9633), "system", 2, new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789") },
                    { new Guid("62676589-b3a9-4b71-814b-8085925c512a"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9639), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9642), "system", 1, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("54a2a82a-94fb-432e-a450-f18d8501348f"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9707), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9710), "system", 1, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("151df737-0a37-4703-ac94-3e5f4d5394bd"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9716), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9719), "system", 1, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("49b83555-d6d8-4157-b611-8428eb14c312"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9724), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9727), "system", 1, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("17bc84f6-b363-45b5-8262-9f9456cce1d2"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9732), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9735), "system", 1, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("b08fff39-bbc6-4fd7-a329-54a3237cbc9a"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9741), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9743), "system", 2, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("73cd40b1-0f93-489c-8ec3-4d6ef49c3c85"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9749), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9752), "system", 2, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("961c48bf-e0a7-49ef-8382-1902feaa2e32"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9757), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9760), "system", 2, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("d22ef290-38c9-4d91-b624-186b945fa21c"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9517), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9520), "system", 2, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("cc58da2b-c410-426a-ad75-7e08dac356da"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9255), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9258), "system", 1, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("bc09338d-a2ac-44f8-927d-3992c927b40a"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9509), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9512), "system", 2, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("53bc9ace-f44e-4c00-88a7-66d456c6245c"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9492), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9495), "system", 1, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("2e50ff2e-aa12-48a1-b33a-c6d561c7403c"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9271), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9274), "system", 1, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("4e94d52f-7d66-4902-9c03-9493c5865490"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9319), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9323), "system", 1, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("c9732827-f424-4ec7-8e75-3599703fd208"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9329), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9332), "system", 1, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("f448e854-f675-486c-95aa-7138c41ca649"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9338), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9340), "system", 2, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("95790344-033a-4dad-9c9f-4a21ea848b04"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9346), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9349), "system", 2, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("1754a10c-152f-4d70-95c6-af1adb5e201a"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9354), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9358), "system", 2, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("19a3e7d8-e9ec-4a0b-974b-2c24d0704d8a"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9363), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9366), "system", 2, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("71edcd72-584b-4e94-8314-2c7a658118c3"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9371), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9376), "system", 2, new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c") },
                    { new Guid("5315718a-df30-4fc6-99af-6aaa0856e427"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9382), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9385), "system", 1, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("cecfe71d-0437-4f6b-b6c6-1fc210bce884"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9390), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9393), "system", 1, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("d46a80d7-7f6c-47ae-b040-9cd9a0b6c04c"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9398), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9401), "system", 1, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("c3ec4bae-1e37-42c2-ae4f-a4267f616056"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9406), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9409), "system", 1, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("95527624-7cdf-4ea5-8229-6d6ecac5c4b7"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9414), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9417), "system", 1, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("539ff638-523c-4b97-8a84-0896b7f74e2b"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9423), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9426), "system", 2, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("2780d08c-4f16-41f7-a244-e2d5add26a54"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9431), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9434), "system", 2, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("7f05dfa5-c6af-4c34-a27d-a312ac187654"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9439), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9442), "system", 2, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("c7af06a7-a597-40d7-9481-8e04b07a3229"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9448), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9450), "system", 2, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("9fe28a4c-8760-468c-b897-706ff1ee3d19"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9456), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9460), "system", 2, new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3") },
                    { new Guid("79854e89-3695-46c4-9e9f-c417d0e5f1e7"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9466), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9469), "system", 1, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("ed29f160-5612-42ad-8843-d17bfe31be15"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9475), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9478), "system", 1, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("ccf7a3c3-f4bb-4584-8bbc-e5c0f31298b5"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9483), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9486), "system", 1, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("944c5459-a140-4541-b4f2-444f50862919"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9501), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9504), "system", 1, new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b") },
                    { new Guid("0ea7552a-94bf-42f6-a24c-eff710506fd8"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8575), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8582), "system", 1, new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215") },
                    { new Guid("bbbfb1e8-eea9-4794-a951-ffb7bc6e99ed"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8552), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8556), "system", 2, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("b1d627a1-944c-42dc-8f0e-284a6199302f"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8539), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8543), "system", 2, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("4790df97-e274-49b0-8471-97711fadefb0"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7450), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7461), "system", 2, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("7f7239d0-da05-4875-b239-b7b5e3e2b4f0"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7466), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7469), "system", 2, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("592364f4-b466-4318-ba08-4afcba6dec4d"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7475), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7478), "system", 2, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("d299ecb8-3f26-4fe2-a186-de7764578d7e"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7483), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7486), "system", 2, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("b17516f5-f632-4f5b-b15d-c51a3f966a81"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7492), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7495), "system", 1, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("f9b1cfa9-7a7a-4e09-932a-d6473b70c946"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7505), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7507), "system", 1, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("582be26b-732f-488f-b57d-2a9313fb051a"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7513), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7516), "system", 1, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("a609a908-300a-4648-b144-aa627656f010"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7545), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7548), "system", 1, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("7b9415c3-3bc6-442f-99de-aafa58cc331d"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7554), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7556), "system", 1, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("aa83b936-26c0-473c-a75c-5a296290bbd6"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7568), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7571), "system", 2, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("397863b2-262e-4cfc-a2aa-1b7b05bb4667"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7577), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7580), "system", 2, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("f1742aa9-2cb0-4146-b73a-9848d23e6863"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7585), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7588), "system", 2, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("af087e5e-92cd-40cd-b824-9af679de52ba"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7593), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7596), "system", 2, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("3c0c6c17-ff10-49a1-8a42-3ce397178fe8"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7602), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7604), "system", 2, new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92") },
                    { new Guid("5811d942-9753-45b3-91d5-a38f8164e35d"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7611), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7614), "system", 1, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("34339738-5be1-452b-8aa8-d3d9cba65d90"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7619), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7622), "system", 1, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("f2c06824-1307-4417-93cd-f222ee28dd68"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7628), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7631), "system", 1, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("c318f729-f995-4abd-bc0a-d65f01492c23"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7636), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7639), "system", 1, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("ea216318-faf1-4f19-87df-12f54d13ccf4"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7644), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7647), "system", 1, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("d4f5de42-a168-4204-aaef-98081bf10940"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7653), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7656), "system", 2, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("b1bb0eaf-ba89-4583-a95c-ee933390ad63"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7662), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7665), "system", 2, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("1567881c-e8fa-46a8-afa8-91e5cb970ff1"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7441), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7444), "system", 2, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("12f7f8ad-e81c-4f29-8bd0-ff6735691b48"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7670), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7673), "system", 2, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("ab06e10e-6f58-471e-a2ca-e7d91a1114dd"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7433), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7436), "system", 1, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("26509f76-2ab3-400c-b4bc-d2f6136a7ad6"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7416), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7419), "system", 1, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("a1982928-fdfe-418b-9048-7b9e852f4fc0"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7049), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7053), "system", 1, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("dd428ec6-c2d8-4f7b-8fe0-d47498902d18"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7065), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7068), "system", 1, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("849fbd0c-2e62-4f3c-ae99-e1eb577ed26e"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7074), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7078), "system", 1, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("f333233f-c5df-4118-9159-2c24ec00a4ce"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7083), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7086), "system", 1, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("3c39d84c-d2e9-45b3-ad2d-81e4f63cf28b"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7098), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7101), "system", 2, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("ee51ebee-70cd-4ff9-88a1-3872de9eef00"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7107), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7110), "system", 2, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("e3eebe0d-ffaa-41ac-a782-202be34edb0e"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7116), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7119), "system", 2, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("0c9e45f9-a850-4ef0-bed5-58dc09eaa9fe"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7124), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7127), "system", 2, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("12e0d393-e838-4d21-94bb-89a720e62ce6"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7134), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7136), "system", 2, new Guid("28b762f2-9c41-4c0c-8546-5953861674e6") },
                    { new Guid("1f37b217-e851-4199-8887-f5c3794e64c5"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7147), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7150), "system", 1, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("e3ade2a4-11b6-4f80-9b24-aaa33ccafceb"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7155), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7158), "system", 1, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("fbc48b45-0a28-4a79-9fe9-a9435b5074f9"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7164), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7167), "system", 1, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("b78f78a4-cfb6-4289-b97d-af9b6218d16c"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7172), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7175), "system", 1, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("c080ff0c-e992-4248-90a8-cc31e2fabab8"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7180), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7183), "system", 1, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("9102ddc6-f15a-40e7-b670-7dda6b8d7fd6"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7189), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7192), "system", 2, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("8e54b763-f88e-4c1e-b9f0-8e0da0420214"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7197), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7200), "system", 2, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("9c817c17-dcf1-4baa-87af-9dcbfc765f14"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7206), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7209), "system", 2, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("52fbc5f8-91c6-40b5-a9cf-69d1dd692ffa"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7380), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7383), "system", 2, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("9fb887b5-2e40-4621-aec8-c8d998330e87"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7390), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7393), "system", 2, new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff") },
                    { new Guid("d22fb7a0-ab28-48d2-8400-91ed84cd0bd4"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7399), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7402), "system", 1, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("54c97d29-5c17-4217-a8e7-2c480210ed8f"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7408), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7411), "system", 1, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("29621792-b943-42ea-bc11-084b0ef56cba"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7424), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7427), "system", 1, new Guid("354f67f3-faf9-4481-aa0e-497fac62213f") },
                    { new Guid("d20ba6af-3029-4ec5-a2af-61554ce4af09"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7678), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7681), "system", 2, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("2cde2b2c-cfec-409b-901d-f041a1034dbc"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7687), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7690), "system", 2, new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1") },
                    { new Guid("6dfa3cdd-b8df-49ac-b712-31f220e247a7"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7697), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7700), "system", 1, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("8083ebc5-41ac-447f-abba-c61bb41cce52"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8125), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8128), "system", 2, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("8f088067-57ae-47fb-ab91-6fc4cd1ffff0"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8134), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8137), "system", 2, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("133bc0ec-644a-4887-a879-ac4609a2d4db"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8142), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8145), "system", 2, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("92a1bf89-6ab3-481a-9031-7fbc2c704541"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8152), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8155), "system", 1, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("52bdeb13-db27-4908-ad8a-bc2b7e22f8b6"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8160), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8163), "system", 1, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("7df6eb3a-3d19-46d0-8216-07b550d8e88a"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8168), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8171), "system", 1, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("f177977e-cc7f-4d01-9dde-d39c083232fb"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8176), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8179), "system", 1, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("e5fd37eb-e7a2-48ba-b752-8c7888592878"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8184), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8188), "system", 1, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("a0889075-2987-4b62-adf0-6ee9e4fc0405"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8193), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8196), "system", 2, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("93649c1b-175c-449c-91ac-460f96e23615"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8360), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8363), "system", 2, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("7fdf2929-56d0-4ae0-aeb2-0cfd76b16e50"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8372), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8375), "system", 2, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("648a06a1-3710-44e1-841a-350c9247f89d"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8380), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8383), "system", 2, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("66d85773-8a7e-4407-b215-ea587f5f719e"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8389), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8392), "system", 2, new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee") },
                    { new Guid("1d4f480e-6be1-4011-aecd-e49ac9e613a7"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8402), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8406), "system", 1, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("75f0bd0f-2212-4206-a20b-2dce1cbae11d"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8413), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8417), "system", 1, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("5e2bcbec-e2d8-4ca0-8deb-7ea9136b1e62"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8425), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8429), "system", 1, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("eae4a4a9-b64b-4836-b6c2-e43cef20b8a4"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8437), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8442), "system", 1, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("bd02b247-fc67-4869-8cc8-27d0b2b40128"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8451), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8455), "system", 1, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("1991719b-3a99-4af9-9967-1a16427df931"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8463), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8467), "system", 2, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("e8e57a28-6deb-4f48-8500-95c476d5d129"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8475), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8479), "system", 2, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("60baff62-6865-46f3-a5df-29ec03d25910"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8519), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8528), "system", 2, new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5") },
                    { new Guid("99a7ca27-d1e3-4d68-885e-9d06007b54ba"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8116), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8119), "system", 2, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("8add5c06-9e4f-4626-84ee-f3ea5f629718"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8108), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8111), "system", 2, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("2bf06a9d-a765-42d8-a980-eee0a3f8c8c8"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8100), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8103), "system", 1, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("90206926-8ff1-4329-adb5-e44a3cf618f6"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8092), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8095), "system", 1, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("77134c25-81b6-4496-902f-2b94d78066b6"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7705), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7708), "system", 1, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("b4a10c77-1c2e-45a4-9c5e-b6030a991a8a"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7713), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7716), "system", 1, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("720d0abb-431f-42a2-b80c-256f08c758e4"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7910), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7916), "system", 1, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("661cedaf-5c5a-4743-9141-cae445d18760"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7924), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7927), "system", 1, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("9a597bac-bdcf-4e59-98e5-809e99e21686"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7933), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7936), "system", 2, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("38368942-6561-41e7-bad8-144bcbe66bb7"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7942), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7945), "system", 2, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("0c03e343-4e18-4403-bcc2-eb846998b007"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7950), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7953), "system", 2, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("455a6cb9-28f0-4723-8c64-df3f5a1cbab3"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7958), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7961), "system", 2, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("5b0a219c-9313-40b5-8844-7b5eb180bb0f"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7967), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7970), "system", 2, new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b") },
                    { new Guid("f8238885-1ee2-4195-9aa3-f86c27cb7589"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7976), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7979), "system", 1, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("bde9ec32-18b1-4b1d-8772-7fd743e59211"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9765), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9768), "system", 2, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") },
                    { new Guid("04b614ee-0214-4ebb-b2b8-b02afc8f4c18"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7984), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7987), "system", 1, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("69d5ea8c-6b0d-4d08-afed-60c30beed9c0"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8001), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8004), "system", 1, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("3c2c6fe8-a896-4163-b22b-e02e2c7783c4"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8009), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8012), "system", 1, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("53b320cc-8c82-40cd-9f8d-6ac6105917f2"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8019), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8022), "system", 2, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("f3112842-e13a-4417-b088-0bbc3aa00d97"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8028), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8031), "system", 2, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("f1670d96-082c-4d75-8d0c-9cd49772403d"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8036), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8039), "system", 2, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("93114664-981b-464d-bc5d-b6fb840fe3fb"), 4, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8045), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8048), "system", 2, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("995b64b1-eff5-455c-b26e-f3852eefdc36"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8053), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8056), "system", 2, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("0976f23e-47ae-4844-a3ed-1c536b497c95"), 1, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8062), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8065), "system", 1, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("2c015cf2-c36f-4f8d-bf7f-ca91ef2baa7e"), 2, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8074), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8077), "system", 1, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("eff45c57-65e6-4099-a482-051c873bd2a3"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8084), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(8086), "system", 1, new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e") },
                    { new Guid("94d7e3cf-ef7d-4cd3-9b7a-8eb7d4f893b1"), 3, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7993), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(7996), "system", 1, new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e") },
                    { new Guid("9fac9502-fe81-4826-9a87-a7edaf242a46"), 5, "system", new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9773), new DateTime(2019, 6, 15, 15, 20, 43, 192, DateTimeKind.Local).AddTicks(9776), "system", 2, new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Compartments_Shelves_ShelfGuid",
                table: "Compartments",
                column: "ShelfGuid",
                principalTable: "Shelves",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compartments_Shelves_ShelfGuid",
                table: "Compartments");

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("008aa56b-3022-4387-b036-2572b6bb3cd7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("04b614ee-0214-4ebb-b2b8-b02afc8f4c18"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("0976f23e-47ae-4844-a3ed-1c536b497c95"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("0c03e343-4e18-4403-bcc2-eb846998b007"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("0c9e45f9-a850-4ef0-bed5-58dc09eaa9fe"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("0ea7552a-94bf-42f6-a24c-eff710506fd8"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("12e0d393-e838-4d21-94bb-89a720e62ce6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("12f7f8ad-e81c-4f29-8bd0-ff6735691b48"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("133bc0ec-644a-4887-a879-ac4609a2d4db"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("151df737-0a37-4703-ac94-3e5f4d5394bd"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("1567881c-e8fa-46a8-afa8-91e5cb970ff1"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("1754a10c-152f-4d70-95c6-af1adb5e201a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("17bc84f6-b363-45b5-8262-9f9456cce1d2"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("18289f04-544e-4f02-b38b-1fcb0007e818"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("187b66a4-ffcd-4552-99f5-44078991efa6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("19027aa6-d013-436e-864c-cd4e23104cc6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("1991719b-3a99-4af9-9967-1a16427df931"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("19a3e7d8-e9ec-4a0b-974b-2c24d0704d8a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("1d4f480e-6be1-4011-aecd-e49ac9e613a7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("1f37b217-e851-4199-8887-f5c3794e64c5"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("26509f76-2ab3-400c-b4bc-d2f6136a7ad6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2780d08c-4f16-41f7-a244-e2d5add26a54"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("27968e60-1510-4eda-807c-2a9485906a81"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("29621792-b943-42ea-bc11-084b0ef56cba"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("29dfacec-8bbb-4606-9ffa-ec6ff0cd8c8b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2accfa6b-2930-4068-9f05-8481786d71e4"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2af20c16-5f32-47a9-9d02-9758fb5f5a84"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2bf06a9d-a765-42d8-a980-eee0a3f8c8c8"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2c015cf2-c36f-4f8d-bf7f-ca91ef2baa7e"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2cde2b2c-cfec-409b-901d-f041a1034dbc"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2e50ff2e-aa12-48a1-b33a-c6d561c7403c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("2fdccaae-0557-49ae-8397-31a20024cf59"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("34339738-5be1-452b-8aa8-d3d9cba65d90"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("3497b4b3-f2f5-4e0b-bda4-6939cc114db8"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("35bb99c0-e353-469a-a28f-5af1aa31ae73"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("38368942-6561-41e7-bad8-144bcbe66bb7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("38424167-e621-4e79-b224-91fcf67f353c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("397863b2-262e-4cfc-a2aa-1b7b05bb4667"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("3b10f4c9-14e1-4a59-99a5-a6ca8984d771"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("3bafb4db-f870-4540-9493-6b26387ec25a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("3c0c6c17-ff10-49a1-8a42-3ce397178fe8"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("3c2c6fe8-a896-4163-b22b-e02e2c7783c4"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("3c39d84c-d2e9-45b3-ad2d-81e4f63cf28b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("3f5fb9fe-e052-4ccc-9c55-cf05c6f31bae"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("41e82162-e790-4fab-85da-6d452a7b14c2"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("42dc0a36-7452-40d9-b209-3132a80cdd70"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("455a6cb9-28f0-4723-8c64-df3f5a1cbab3"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("4605d1de-e9ff-427e-97aa-4aad9d87a151"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("4790df97-e274-49b0-8471-97711fadefb0"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("49b83555-d6d8-4157-b611-8428eb14c312"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("4d055871-7725-4e96-b9fb-5a695612e8c7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("4e94d52f-7d66-4902-9c03-9493c5865490"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("4fda7c05-4f9a-42d6-b6eb-97135ca6df26"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5113d883-c0f8-4b2b-b2b9-7b63f27cb75f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("515cd0cc-bf65-478e-b484-c73edffe5b05"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("51dbbfe2-6982-44ba-b87b-1b6bb3ccfd9f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("52335787-b378-4ade-a58a-71a9cbb81dfc"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("52bdeb13-db27-4908-ad8a-bc2b7e22f8b6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("52fbc5f8-91c6-40b5-a9cf-69d1dd692ffa"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5315718a-df30-4fc6-99af-6aaa0856e427"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("539ff638-523c-4b97-8a84-0896b7f74e2b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("53b320cc-8c82-40cd-9f8d-6ac6105917f2"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("53bc9ace-f44e-4c00-88a7-66d456c6245c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("54202658-d8cb-4e6b-ab55-df5f93724acc"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("54a2a82a-94fb-432e-a450-f18d8501348f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("54c97d29-5c17-4217-a8e7-2c480210ed8f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("551cdf8b-a45b-4774-babf-0dad29198bac"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5811d942-9753-45b3-91d5-a38f8164e35d"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("582be26b-732f-488f-b57d-2a9313fb051a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("592364f4-b466-4318-ba08-4afcba6dec4d"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5b0a219c-9313-40b5-8844-7b5eb180bb0f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5c44d385-dedd-4d65-b676-a901a50fc119"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5da6ca7e-a856-41d9-934c-56d19020362f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5e2bcbec-e2d8-4ca0-8deb-7ea9136b1e62"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("5ef487eb-cbe3-4f3a-ad88-39cfac44d0de"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("6036338d-296b-4b70-8f86-3d3b4c698fce"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("60baff62-6865-46f3-a5df-29ec03d25910"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("62676589-b3a9-4b71-814b-8085925c512a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("627122b2-37fb-4a4e-bd79-2c845cd2dbf3"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("648a06a1-3710-44e1-841a-350c9247f89d"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("657750aa-8dc5-4fe5-8c01-fef4126b5a1a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("661cedaf-5c5a-4743-9141-cae445d18760"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("66d85773-8a7e-4407-b215-ea587f5f719e"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("69368ac4-2784-4725-aa69-6f2caee201a0"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("69d5ea8c-6b0d-4d08-afed-60c30beed9c0"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("6b252adb-e3ce-492a-91d3-915a7af7485d"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("6bd6b0db-f6ef-4938-8870-438b65560639"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("6dfa3cdd-b8df-49ac-b712-31f220e247a7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("6f772471-e6ef-44d2-8aa5-94028ae806e8"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("71edcd72-584b-4e94-8314-2c7a658118c3"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("720d0abb-431f-42a2-b80c-256f08c758e4"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("73cd40b1-0f93-489c-8ec3-4d6ef49c3c85"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("75f0bd0f-2212-4206-a20b-2dce1cbae11d"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("77134c25-81b6-4496-902f-2b94d78066b6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("79854e89-3695-46c4-9e9f-c417d0e5f1e7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("7b9415c3-3bc6-442f-99de-aafa58cc331d"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("7df6eb3a-3d19-46d0-8216-07b550d8e88a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("7f05dfa5-c6af-4c34-a27d-a312ac187654"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("7f56412b-00cb-4f15-a810-f30e5a477724"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("7f7239d0-da05-4875-b239-b7b5e3e2b4f0"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("7fdf2929-56d0-4ae0-aeb2-0cfd76b16e50"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("8083ebc5-41ac-447f-abba-c61bb41cce52"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("849fbd0c-2e62-4f3c-ae99-e1eb577ed26e"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("89da5de3-d9fe-4009-a972-9b4584845293"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("8add5c06-9e4f-4626-84ee-f3ea5f629718"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("8deaa195-ba88-416c-b257-199e9fe42335"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("8e54b763-f88e-4c1e-b9f0-8e0da0420214"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("8f088067-57ae-47fb-ab91-6fc4cd1ffff0"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("90206926-8ff1-4329-adb5-e44a3cf618f6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("9102ddc6-f15a-40e7-b670-7dda6b8d7fd6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("92a1bf89-6ab3-481a-9031-7fbc2c704541"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("92c7728b-d7bc-4e99-8d85-12102c21bd42"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("93114664-981b-464d-bc5d-b6fb840fe3fb"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("93649c1b-175c-449c-91ac-460f96e23615"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("944c5459-a140-4541-b4f2-444f50862919"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("94d7e3cf-ef7d-4cd3-9b7a-8eb7d4f893b1"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("95527624-7cdf-4ea5-8229-6d6ecac5c4b7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("95790344-033a-4dad-9c9f-4a21ea848b04"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("961c48bf-e0a7-49ef-8382-1902feaa2e32"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("96991278-73ae-4bb9-9200-6769d7f991d7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("995b64b1-eff5-455c-b26e-f3852eefdc36"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("99a7ca27-d1e3-4d68-885e-9d06007b54ba"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("9a2b070d-2fd9-4433-8ccd-f8c51420f961"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("9a597bac-bdcf-4e59-98e5-809e99e21686"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("9c817c17-dcf1-4baa-87af-9dcbfc765f14"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("9fac9502-fe81-4826-9a87-a7edaf242a46"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("9fb887b5-2e40-4621-aec8-c8d998330e87"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("9fe28a4c-8760-468c-b897-706ff1ee3d19"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("a0889075-2987-4b62-adf0-6ee9e4fc0405"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("a1982928-fdfe-418b-9048-7b9e852f4fc0"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("a3b01218-20f9-4910-8002-6c182cacae54"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("a519a173-166b-460f-ae47-18e5f11ededf"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("a609a908-300a-4648-b144-aa627656f010"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("a8df6e04-4852-4491-9a65-144dc4e9b414"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("aa83b936-26c0-473c-a75c-5a296290bbd6"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("ab06e10e-6f58-471e-a2ca-e7d91a1114dd"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("abb6045d-8399-4ab8-a01f-342aff9ef97c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("acc497c3-c111-45ac-8f40-36b2b572d5b7"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("af087e5e-92cd-40cd-b824-9af679de52ba"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("b08fff39-bbc6-4fd7-a329-54a3237cbc9a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("b17516f5-f632-4f5b-b15d-c51a3f966a81"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("b1bb0eaf-ba89-4583-a95c-ee933390ad63"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("b1d627a1-944c-42dc-8f0e-284a6199302f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("b4a10c77-1c2e-45a4-9c5e-b6030a991a8a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("b78f78a4-cfb6-4289-b97d-af9b6218d16c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("ba9f89b3-0add-4dd8-b365-7681ba3e7e2c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("bad3fa7a-7601-43b4-8640-02edc286ea5b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("bbbfb1e8-eea9-4794-a951-ffb7bc6e99ed"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("bc09338d-a2ac-44f8-927d-3992c927b40a"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("bd02b247-fc67-4869-8cc8-27d0b2b40128"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("bdce802e-3f4f-4262-a3d6-420156a7e61b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("bde9ec32-18b1-4b1d-8772-7fd743e59211"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("c080ff0c-e992-4248-90a8-cc31e2fabab8"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("c318f729-f995-4abd-bc0a-d65f01492c23"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("c3ec4bae-1e37-42c2-ae4f-a4267f616056"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("c5714c92-0dab-48d1-8037-8a518a291970"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("c7af06a7-a597-40d7-9481-8e04b07a3229"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("c9732827-f424-4ec7-8e75-3599703fd208"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("c9f9b4dc-e5d9-466c-8a76-f8f4d74925a3"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("cc58da2b-c410-426a-ad75-7e08dac356da"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("ccf7a3c3-f4bb-4584-8bbc-e5c0f31298b5"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("cecfe71d-0437-4f6b-b6c6-1fc210bce884"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("cfb7d7ca-8fdb-4f0a-91a8-1659b9141d8b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d20ba6af-3029-4ec5-a2af-61554ce4af09"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d22ef290-38c9-4d91-b624-186b945fa21c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d22fb7a0-ab28-48d2-8400-91ed84cd0bd4"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d299ecb8-3f26-4fe2-a186-de7764578d7e"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d46a80d7-7f6c-47ae-b040-9cd9a0b6c04c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d4f5de42-a168-4204-aaef-98081bf10940"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d5ef4118-a5d8-4713-8651-4815a239e91b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("d9a55745-5576-40f0-af0e-eab4410d3649"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("dd428ec6-c2d8-4f7b-8fe0-d47498902d18"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("e1973445-0a84-4d2f-aa7f-78fcbf27fd8c"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("e3ade2a4-11b6-4f80-9b24-aaa33ccafceb"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("e3eebe0d-ffaa-41ac-a782-202be34edb0e"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("e5fd37eb-e7a2-48ba-b752-8c7888592878"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("e8e57a28-6deb-4f48-8500-95c476d5d129"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("ea216318-faf1-4f19-87df-12f54d13ccf4"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("eaae9d52-c90e-4616-a4f6-b92ab0205c0b"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("eae4a4a9-b64b-4836-b6c2-e43cef20b8a4"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("ed013250-f02f-43a5-8ab5-b6d197159d20"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("ed29f160-5612-42ad-8843-d17bfe31be15"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("ee51ebee-70cd-4ff9-88a1-3872de9eef00"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("eff45c57-65e6-4099-a482-051c873bd2a3"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f1670d96-082c-4d75-8d0c-9cd49772403d"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f1742aa9-2cb0-4146-b73a-9848d23e6863"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f177977e-cc7f-4d01-9dde-d39c083232fb"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f2c06824-1307-4417-93cd-f222ee28dd68"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f2dc1a47-e658-4f78-8117-a9acbfd416ce"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f3112842-e13a-4417-b088-0bbc3aa00d97"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f333233f-c5df-4118-9159-2c24ec00a4ce"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f3710e61-316a-4324-8014-a091fbc97f0f"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f448e854-f675-486c-95aa-7138c41ca649"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f57ae8db-4a8b-4c77-9b32-fba1f72634a9"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f8043cb7-123b-42ed-9d84-916327e51288"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f8238885-1ee2-4195-9aa3-f86c27cb7589"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("f9b1cfa9-7a7a-4e09-932a-d6473b70c946"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("fbc48b45-0a28-4a79-9fe9-a9435b5074f9"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("fc6ec2a2-af8e-4c27-95d3-7a46b9fa3e21"));

            migrationBuilder.DeleteData(
                table: "Compartments",
                keyColumn: "Guid",
                keyValue: new Guid("fd3ac05d-e526-4228-80aa-45a07854ab12"));

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), new Guid("273a60ce-7282-4141-9676-1c3040ec1303") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("65231084-3178-4259-886c-4698a02c701d"), new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), new Guid("426a9547-086d-4847-a80e-00140da99723") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee") });

            migrationBuilder.DeleteData(
                table: "Roles_Departments",
                keyColumns: new[] { "RoleGuid", "DepartmentGuid" },
                keyValues: new object[] { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af") });

            migrationBuilder.DeleteData(
                table: "Roles_Employees",
                keyColumns: new[] { "RoleGuid", "EmployeeGuid" },
                keyValues: new object[] { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf") });

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("273a60ce-7282-4141-9676-1c3040ec1303"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("426a9547-086d-4847-a80e-00140da99723"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Guid",
                keyValue: new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("65231084-3178-4259-886c-4698a02c701d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("03853f6f-e1fe-4291-ac94-08f7bcadeaa3"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("0fbc6908-74dc-4698-bb1b-bad9774f0d0c"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("28b762f2-9c41-4c0c-8546-5953861674e6"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("3112ef18-8910-4e7f-9f2b-18dde9b3c3ee"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("354f67f3-faf9-4481-aa0e-497fac62213f"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("5fbcf43e-e593-4f3b-b320-00384db60d92"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("663fbe6a-91af-49fb-94c3-700e1cb607ff"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("699abb29-fa4c-4dac-98c3-5e23e29b5483"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("73dbd9e0-632f-4a20-b771-2e828eaa0ac3"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("887b444e-ba8b-47c4-bbfa-05340d9b062e"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("936c889e-d905-476b-960a-41f0b7a81f6f"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("9b71cd37-5a91-42e1-8597-81c4af2f836b"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("a8694e9a-b0e5-4ff9-be07-2abd77d288c1"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("c7c5edd9-6ca6-43c8-883c-c61abe66577e"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("d4542c33-19fa-42d1-b62f-1742c0f4efdf"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("d67a4d75-50a8-4291-b8c8-a278ea48900b"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("e39a9714-e03a-41fe-b8b4-e2a2a76b9789"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("f3ed3308-7ca6-4789-b94d-41c9e1f239d5"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("fa18798d-911d-41be-9f03-7fb89e4d7b17"));

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Guid",
                keyValue: new Guid("fbf32c64-da20-463a-a6bc-2801f58c5215"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Guid",
                keyValue: new Guid("45b9b2e3-3fd7-4000-950a-781241c33656"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Guid",
                keyValue: new Guid("f722d8d7-405a-42fb-bdda-4c69d648c3ab"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Guid",
                keyValue: new Guid("3c3f2e8a-2ec3-45ea-8273-99e76d71190f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Guid",
                keyValue: new Guid("5dd4e453-19a0-4cef-abfd-4cac78037490"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Guid",
                keyValue: new Guid("7ac5c068-2194-40d2-8d78-95f6b8c62f4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Guid",
                keyValue: new Guid("0906d22f-39c2-4619-8c5b-1ba73db80f64"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ShelfGuid",
                table: "Compartments",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(4670), "The management of the firm", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(5679), "system", "Management" },
                    { new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8346), "The finance department of the firm", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8372), "system", "Finance" },
                    { new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8422), "The hr department of the firm", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8428), "system", "HR" },
                    { new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8446), "The sales department of the firm", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8451), "system", "Sales" },
                    { new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8466), "The purchase department of the firm", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8471), "system", "Purchase" },
                    { new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8488), "The logistics department of the firm", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8493), "system", "Logistic" },
                    { new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8508), "The production department of the firm", new DateTime(2019, 6, 8, 13, 47, 48, 58, DateTimeKind.Local).AddTicks(8513), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(5181), "Employee from the logistics department", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(5205), "system", "Logistic" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6078), "Employee from the finances department", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6085), "system", "Finance" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6101), "Employee from the purchases department", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6103), "system", "Purchase" },
                    { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6112), "Administrators of the app", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6114), "system", "SysAdmin" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6122), "Employee from the sales department", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6124), "system", "Sale" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6133), "Employee from the management", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6135), "system", "Management" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6142), "Employee from the hr department", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6144), "system", "HR" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6152), "Employee from the production department", new DateTime(2019, 6, 8, 13, 47, 48, 96, DateTimeKind.Local).AddTicks(6154), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 8, 13, 47, 48, 62, DateTimeKind.Local).AddTicks(7716), new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "admin@clerp.ch", "System", new DateTime(2019, 6, 8, 13, 47, 48, 62, DateTimeKind.Local).AddTicks(9211), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles_Departments",
                columns: new[] { "RoleGuid", "DepartmentGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8675), new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8678), "system" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8587), new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8600), "system" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8651), new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8654), "system" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8637), new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8640), "system" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(6872), new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(7647), "system" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8621), new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8624), "system" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8690), new DateTime(2019, 6, 8, 13, 47, 48, 113, DateTimeKind.Local).AddTicks(8692), "system" }
                });

            migrationBuilder.InsertData(
                table: "Roles_Employees",
                columns: new[] { "RoleGuid", "EmployeeGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), "system", new DateTime(2019, 6, 8, 13, 47, 48, 116, DateTimeKind.Local).AddTicks(9462), new DateTime(2019, 6, 8, 13, 47, 48, 116, DateTimeKind.Local).AddTicks(9473), "system" });

            migrationBuilder.AddForeignKey(
                name: "FK_Compartments_Shelves_ShelfGuid",
                table: "Compartments",
                column: "ShelfGuid",
                principalTable: "Shelves",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
