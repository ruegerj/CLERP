using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class AddedDepartmentToSeedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(6391), "The management of the firm", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(7290), "system", "Management" },
                    { new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9101), "The finance department of the firm", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9115), "system", "Finance" },
                    { new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9140), "The hr department of the firm", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9143), "system", "HR" },
                    { new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9152), "The sales department of the firm", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9155), "system", "Sales" },
                    { new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9162), "The purchase department of the firm", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9164), "system", "Purchase" },
                    { new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9172), "The logistics department of the firm", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9175), "system", "Logistic" },
                    { new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9182), "The production department of the firm", new DateTime(2019, 6, 8, 13, 33, 23, 902, DateTimeKind.Local).AddTicks(9184), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 8, 13, 33, 23, 906, DateTimeKind.Local).AddTicks(9330), null, "admin@clerp.ch", "System", new DateTime(2019, 6, 8, 13, 33, 23, 907, DateTimeKind.Local).AddTicks(1475), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(665), "Employee from the logistics department", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(696), "system", "Logistic" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1569), "Employee from the finances department", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1579), "system", "Finance" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1596), "Employee from the purchases department", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1598), "system", "Purchase" },
                    { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1605), "Administrators of the app", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1607), "system", "SysAdmin" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1615), "Employee from the sales department", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1617), "system", "Sale" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1626), "Employee from the management", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1628), "system", "Management" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1635), "Employee from the hr department", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1637), "system", "HR" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1643), "Employee from the production department", new DateTime(2019, 6, 8, 13, 33, 23, 935, DateTimeKind.Local).AddTicks(1645), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Roles_Departments",
                columns: new[] { "RoleGuid", "DepartmentGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2728), new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2730), "system" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2653), new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2666), "system" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2712), new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2714), "system" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2700), new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2702), "system" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(1102), new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(1894), "system" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2685), new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2687), "system" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2741), new DateTime(2019, 6, 8, 13, 33, 23, 952, DateTimeKind.Local).AddTicks(2743), "system" }
                });

            migrationBuilder.InsertData(
                table: "Roles_Employees",
                columns: new[] { "RoleGuid", "EmployeeGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), "system", new DateTime(2019, 6, 8, 13, 33, 23, 955, DateTimeKind.Local).AddTicks(3333), new DateTime(2019, 6, 8, 13, 33, 23, 955, DateTimeKind.Local).AddTicks(3347), "system" });
        }
    }
}
