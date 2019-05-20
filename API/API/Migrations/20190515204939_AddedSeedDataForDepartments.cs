using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class AddedSeedDataForDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("03c77024-46b1-4f9c-b00f-0ab84cda6bda"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("660f23ed-608f-4dc6-b7e3-f1ea6236d0ab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("6f61fcc9-6607-4fae-b7f8-bf596d1d186c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("8e1fbbd8-18a6-4f49-9f79-c0a2986c903d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("bdefb7d6-89e4-400d-a731-bb860cd2c2fc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("d37edd3e-b87c-4378-9c79-8daec7c3f64e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("e0858b5c-9f01-4d02-87ba-073b5a8684c9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("ef80c023-deb1-4e85-8614-b184a5ff5252"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("7c1992fb-3af8-4770-bfd1-1386f978772e"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(1786), "The management of the firm", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(2685), "system", "Management" },
                    { new Guid("8ba74c09-bad5-4f5c-bb66-feeed5a457c4"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4595), "The finance department of the firm", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4607), "system", "Finance" },
                    { new Guid("be310a6c-ee1c-40c3-8d0c-079ca2e9cf9f"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4628), "The hr department of the firm", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4631), "system", "HR" },
                    { new Guid("8124e2ac-514f-41fc-a4e5-d254ad47bb86"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4635), "The sales department of the firm", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4637), "system", "Sales" },
                    { new Guid("f50e0988-4a1e-4b8b-9134-86fec6a2d107"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4640), "The purchase department of the firm", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4642), "system", "Purchase" },
                    { new Guid("7634b52c-8746-4fe5-b8db-aa070a63b22a"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4647), "The logistics department of the firm", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4650), "system", "Logistic" },
                    { new Guid("63e64701-69f4-45fc-8a0c-77127716bc7b"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4653), "The production department of the firm", new DateTime(2019, 5, 15, 22, 49, 39, 154, DateTimeKind.Local).AddTicks(4655), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("70890c67-68d1-485a-8de8-3baf45ffb357"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(881), "Employee from the logistics department", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(906), "system", "Logistic" },
                    { new Guid("0929a88f-a53a-426c-95a8-51487b9860c8"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1779), "Employee from the finances department", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1787), "system", "Finance" },
                    { new Guid("1493814e-345a-4e38-ba72-2f8f3bf8261e"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1798), "Employee from the purchases department", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1800), "system", "Purchase" },
                    { new Guid("0d9b6fcf-37bf-4574-8177-fb3102a972d0"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1803), "Administrators of the app", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1805), "system", "SysAdmin" },
                    { new Guid("be9a27d8-e006-4d40-870c-6895199ba4e5"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1808), "Employee from the sales department", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1810), "system", "Sale" },
                    { new Guid("9ed454a5-f135-4fbd-9d54-39552d5404b0"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1848), "Employee from the management", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1851), "system", "Management" },
                    { new Guid("ce030785-9c08-4fc6-8e40-9cc22490cbfc"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1854), "Employee from the hr department", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1856), "system", "HR" },
                    { new Guid("4e6a1923-343a-4066-917b-cecf1d2543d5"), "system", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1859), "Employee from the production department", new DateTime(2019, 5, 15, 22, 49, 39, 184, DateTimeKind.Local).AddTicks(1861), "system", "Production" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("63e64701-69f4-45fc-8a0c-77127716bc7b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("7634b52c-8746-4fe5-b8db-aa070a63b22a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("7c1992fb-3af8-4770-bfd1-1386f978772e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("8124e2ac-514f-41fc-a4e5-d254ad47bb86"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("8ba74c09-bad5-4f5c-bb66-feeed5a457c4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("be310a6c-ee1c-40c3-8d0c-079ca2e9cf9f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("f50e0988-4a1e-4b8b-9134-86fec6a2d107"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("0929a88f-a53a-426c-95a8-51487b9860c8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("0d9b6fcf-37bf-4574-8177-fb3102a972d0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("1493814e-345a-4e38-ba72-2f8f3bf8261e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("4e6a1923-343a-4066-917b-cecf1d2543d5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("70890c67-68d1-485a-8de8-3baf45ffb357"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("9ed454a5-f135-4fbd-9d54-39552d5404b0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("be9a27d8-e006-4d40-870c-6895199ba4e5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("ce030785-9c08-4fc6-8e40-9cc22490cbfc"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("e0858b5c-9f01-4d02-87ba-073b5a8684c9"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(1822), "Employee from the logistics department", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(3102), "system", "Logistic" },
                    { new Guid("8e1fbbd8-18a6-4f49-9f79-c0a2986c903d"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4414), "Employee from the finances department", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4432), "system", "Finance" },
                    { new Guid("d37edd3e-b87c-4378-9c79-8daec7c3f64e"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4454), "Employee from the purchases department", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4457), "system", "Purchase" },
                    { new Guid("03c77024-46b1-4f9c-b00f-0ab84cda6bda"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4466), "Administrators of the app", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4468), "system", "SysAdmin" },
                    { new Guid("660f23ed-608f-4dc6-b7e3-f1ea6236d0ab"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4474), "Employee from the sales department", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4477), "system", "Sale" },
                    { new Guid("bdefb7d6-89e4-400d-a731-bb860cd2c2fc"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4483), "Employee from the management", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4485), "system", "Management" },
                    { new Guid("ef80c023-deb1-4e85-8614-b184a5ff5252"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4490), "Employee from the hr department", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4492), "system", "HR" },
                    { new Guid("6f61fcc9-6607-4fae-b7f8-bf596d1d186c"), "system", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4498), "Employee from the production department", new DateTime(2019, 5, 14, 21, 19, 59, 428, DateTimeKind.Local).AddTicks(4503), "system", "Production" }
                });
        }
    }
}
