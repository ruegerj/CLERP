using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class AddedSeedForTheRolesOFDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(1879), "The management of the firm", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(2816), "system", "Management" },
                    { new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4763), "The finance department of the firm", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4777), "system", "Finance" },
                    { new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4803), "The hr department of the firm", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4806), "system", "HR" },
                    { new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4816), "The sales department of the firm", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4819), "system", "Sales" },
                    { new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4828), "The purchase department of the firm", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4830), "system", "Purchase" },
                    { new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4839), "The logistics department of the firm", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4841), "system", "Logistic" },
                    { new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4849), "The production department of the firm", new DateTime(2019, 6, 8, 13, 26, 49, 123, DateTimeKind.Local).AddTicks(4851), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 8, 13, 26, 49, 126, DateTimeKind.Local).AddTicks(9529), null, "admin@clerp.ch", "System", new DateTime(2019, 6, 8, 13, 26, 49, 127, DateTimeKind.Local).AddTicks(989), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(8990), "Employee from the logistics department", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(9021), "system", "Logistic" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(9959), "Employee from the finances department", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(9968), "system", "Finance" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(9985), "Employee from the purchases department", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(9988), "system", "Purchase" },
                    { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(9996), "Administrators of the app", new DateTime(2019, 6, 8, 13, 26, 49, 158, DateTimeKind.Local).AddTicks(9999), "system", "SysAdmin" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(7), "Employee from the sales department", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(9), "system", "Sale" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(19), "Employee from the management", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(21), "system", "Management" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(28), "Employee from the hr department", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(31), "system", "HR" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(38), "Employee from the production department", new DateTime(2019, 6, 8, 13, 26, 49, 159, DateTimeKind.Local).AddTicks(40), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Roles_Employees",
                columns: new[] { "RoleGuid", "EmployeeGuid", "CreatedBy", "Creation", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), "system", new DateTime(2019, 6, 8, 13, 26, 49, 180, DateTimeKind.Local).AddTicks(5098), new DateTime(2019, 6, 8, 13, 26, 49, 180, DateTimeKind.Local).AddTicks(5112), "system" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Roles_Employees",
                keyColumns: new[] { "RoleGuid", "EmployeeGuid" },
                keyValues: new object[] { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf") });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Guid",
                keyValue: new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(6701), "The management of the firm", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(7654), "system", "Management" },
                    { new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9657), "The finance department of the firm", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9671), "system", "Finance" },
                    { new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9697), "The hr department of the firm", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9700), "system", "HR" },
                    { new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9710), "The sales department of the firm", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9712), "system", "Sales" },
                    { new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9720), "The purchase department of the firm", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9722), "system", "Purchase" },
                    { new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9732), "The logistics department of the firm", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9734), "system", "Logistic" },
                    { new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9741), "The production department of the firm", new DateTime(2019, 6, 8, 12, 20, 29, 881, DateTimeKind.Local).AddTicks(9744), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 8, 12, 20, 29, 885, DateTimeKind.Local).AddTicks(4476), null, "admin@clerp.ch", "System", new DateTime(2019, 6, 8, 12, 20, 29, 885, DateTimeKind.Local).AddTicks(5975), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(5040), "Employee from the logistics department", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(5066), "system", "Logistic" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6047), "Employee from the finances department", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6054), "system", "Finance" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6071), "Employee from the purchases department", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6073), "system", "Purchase" },
                    { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6081), "Administrators of the app", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6084), "system", "SysAdmin" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6092), "Employee from the sales department", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6095), "system", "Sale" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6105), "Employee from the management", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6107), "system", "Management" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6114), "Employee from the hr department", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6117), "system", "HR" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), "system", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6124), "Employee from the production department", new DateTime(2019, 6, 8, 12, 20, 29, 919, DateTimeKind.Local).AddTicks(6126), "system", "Production" }
                });
        }
    }
}
