using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class SetSeedGuidsToStaticValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("20e6b188-bec4-4ea7-9a54-e3c26b9f6cf3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("6c81f8dc-c2da-4f41-943e-d1595294f43c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("7b39acf0-c34e-46b9-b49c-c157f9a0c17f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("8264bce1-da7a-4114-9049-8ff261a75add"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("89135f1e-3161-4e51-985b-8a985cf53579"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("b12fb4c1-cf64-49a7-9b42-3a3cae6765c2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("cb8c65e4-2b4e-4d09-a728-85a9e4b633a6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Guid",
                keyValue: new Guid("1e61a55b-a539-4681-847f-dec9a76edb08"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("21b03ce6-bbcc-4852-bf35-b30482eea21d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("32f99b24-fa27-4a7d-98d2-d6537daf3ff7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("6ed05682-c3ee-4581-b9d9-759b8b09d9c9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("8e887b0f-f7d7-4cbd-a854-7f1c6467416e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("c658b4c5-3ef8-45e9-ae4b-4edcececac78"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("cadcae19-a644-4efa-84cd-ebb55d7f935a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("da6c0f7e-ad7b-4d64-a580-fa920a9af88b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("dacc67c3-d1e0-442e-b548-57be6547210e"));

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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("89135f1e-3161-4e51-985b-8a985cf53579"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 909, DateTimeKind.Local).AddTicks(6958), "The management of the firm", new DateTime(2019, 6, 3, 9, 51, 55, 909, DateTimeKind.Local).AddTicks(8325), "system", "Management" },
                    { new Guid("6c81f8dc-c2da-4f41-943e-d1595294f43c"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1262), "The finance department of the firm", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1282), "system", "Finance" },
                    { new Guid("20e6b188-bec4-4ea7-9a54-e3c26b9f6cf3"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1312), "The hr department of the firm", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1316), "system", "HR" },
                    { new Guid("cb8c65e4-2b4e-4d09-a728-85a9e4b633a6"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1322), "The sales department of the firm", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1326), "system", "Sales" },
                    { new Guid("7b39acf0-c34e-46b9-b49c-c157f9a0c17f"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1330), "The purchase department of the firm", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1334), "system", "Purchase" },
                    { new Guid("8264bce1-da7a-4114-9049-8ff261a75add"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1341), "The logistics department of the firm", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1344), "system", "Logistic" },
                    { new Guid("b12fb4c1-cf64-49a7-9b42-3a3cae6765c2"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1349), "The production department of the firm", new DateTime(2019, 6, 3, 9, 51, 55, 910, DateTimeKind.Local).AddTicks(1352), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("1e61a55b-a539-4681-847f-dec9a76edb08"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 6, 3, 9, 51, 55, 914, DateTimeKind.Local).AddTicks(9802), null, "admin@clerp.ch", "System", new DateTime(2019, 6, 3, 9, 51, 55, 915, DateTimeKind.Local).AddTicks(1992), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("8e887b0f-f7d7-4cbd-a854-7f1c6467416e"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(2865), "Employee from the logistics department", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(2894), "system", "Logistic" },
                    { new Guid("6ed05682-c3ee-4581-b9d9-759b8b09d9c9"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4218), "Employee from the finances department", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4229), "system", "Finance" },
                    { new Guid("c658b4c5-3ef8-45e9-ae4b-4edcececac78"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4244), "Employee from the purchases department", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4248), "system", "Purchase" },
                    { new Guid("32f99b24-fa27-4a7d-98d2-d6537daf3ff7"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4253), "Administrators of the app", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4256), "system", "SysAdmin" },
                    { new Guid("cadcae19-a644-4efa-84cd-ebb55d7f935a"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4261), "Employee from the sales department", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4265), "system", "Sale" },
                    { new Guid("dacc67c3-d1e0-442e-b548-57be6547210e"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4272), "Employee from the management", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4276), "system", "Management" },
                    { new Guid("21b03ce6-bbcc-4852-bf35-b30482eea21d"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4280), "Employee from the hr department", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4284), "system", "HR" },
                    { new Guid("da6c0f7e-ad7b-4d64-a580-fa920a9af88b"), "system", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4289), "Employee from the production department", new DateTime(2019, 6, 3, 9, 51, 55, 956, DateTimeKind.Local).AddTicks(4292), "system", "Production" }
                });
        }
    }
}
