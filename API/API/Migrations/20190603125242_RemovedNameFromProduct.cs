using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class RemovedNameFromProduct : Migration
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(4300), "The management of the firm", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(5182), "system", "Management" },
                    { new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7010), "The finance department of the firm", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7022), "system", "Finance" },
                    { new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7082), "The hr department of the firm", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7085), "system", "HR" },
                    { new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7095), "The sales department of the firm", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7097), "system", "Sales" },
                    { new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7105), "The purchase department of the firm", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7107), "system", "Purchase" },
                    { new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7115), "The logistics department of the firm", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7117), "system", "Logistic" },
                    { new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7124), "The production department of the firm", new DateTime(2019, 6, 3, 14, 52, 42, 321, DateTimeKind.Local).AddTicks(7126), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 3, 14, 52, 42, 324, DateTimeKind.Local).AddTicks(8914), null, "admin@clerp.ch", "System", new DateTime(2019, 6, 3, 14, 52, 42, 325, DateTimeKind.Local).AddTicks(353), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(6748), "Employee from the logistics department", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(6768), "system", "Logistic" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7621), "Employee from the finances department", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7628), "system", "Finance" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7644), "Employee from the purchases department", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7646), "system", "Purchase" },
                    { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7654), "Administrators of the app", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7656), "system", "SysAdmin" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7664), "Employee from the sales department", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7666), "system", "Sale" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7675), "Employee from the management", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7677), "system", "Management" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7685), "Employee from the hr department", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7687), "system", "HR" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), "system", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7693), "Employee from the production department", new DateTime(2019, 6, 3, 14, 52, 42, 351, DateTimeKind.Local).AddTicks(7695), "system", "Production" }
                });
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

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("c0a1d8dc-9d37-4b68-ad4e-420e14fd29af"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(529), "The management of the firm", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(2348), "system", "Management" },
                    { new Guid("4b7f2fb2-2726-49b3-b8ab-6f7b42120dee"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6134), "The finance department of the firm", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6160), "system", "Finance" },
                    { new Guid("98eb6ffe-57bb-4d49-ad13-23195a1325ee"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6213), "The hr department of the firm", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6219), "system", "HR" },
                    { new Guid("426a9547-086d-4847-a80e-00140da99723"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6238), "The sales department of the firm", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6243), "system", "Sales" },
                    { new Guid("273a60ce-7282-4141-9676-1c3040ec1303"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6260), "The purchase department of the firm", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6313), "system", "Purchase" },
                    { new Guid("7e645fd7-25df-4baa-898d-59963c4f4d43"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6333), "The logistics department of the firm", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6337), "system", "Logistic" },
                    { new Guid("2d08de41-25f6-4369-bacb-de75f90cf2ea"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6352), "The production department of the firm", new DateTime(2019, 6, 3, 10, 2, 6, 38, DateTimeKind.Local).AddTicks(6357), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("0dfac9a3-f4b2-47f6-8f91-4e0198e8d6bf"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 3, 10, 2, 6, 45, DateTimeKind.Local).AddTicks(2001), null, "admin@clerp.ch", "System", new DateTime(2019, 6, 3, 10, 2, 6, 45, DateTimeKind.Local).AddTicks(4897), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("90f17bbe-edb8-4e0f-8492-b18d130ef058"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(40), "Employee from the logistics department", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(68), "system", "Logistic" },
                    { new Guid("d34ce4a4-6fae-4623-9cf9-7468a19781fb"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1343), "Employee from the finances department", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1354), "system", "Finance" },
                    { new Guid("58457e73-da9f-4f6e-b31b-7f89807e320c"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1377), "Employee from the purchases department", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1381), "system", "Purchase" },
                    { new Guid("324270ba-fc55-41de-95f2-943fc628c5ee"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1393), "Administrators of the app", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1396), "system", "SysAdmin" },
                    { new Guid("b6bab4db-bd5d-4b34-a6e5-085204c16c79"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1409), "Employee from the sales department", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1412), "system", "Sale" },
                    { new Guid("ed32b358-5eb5-41ad-8895-e65641f8d1bd"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1426), "Employee from the management", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1430), "system", "Management" },
                    { new Guid("e0c8423a-581f-4be9-8493-1b20aee0673a"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1440), "Employee from the hr department", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1444), "system", "HR" },
                    { new Guid("65231084-3178-4259-886c-4698a02c701d"), "system", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1454), "Employee from the production department", new DateTime(2019, 6, 3, 10, 2, 6, 86, DateTimeKind.Local).AddTicks(1457), "system", "Production" }
                });
        }
    }
}
