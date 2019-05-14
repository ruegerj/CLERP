using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class AddedMetaDataForLinkEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("0f72beb1-997c-4913-806d-12cb27d1f438"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("143dcc6f-9cd3-4191-9a84-e24378efd676"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("3cb00335-216a-4788-bae4-76d98a21fdbf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("69f70b9a-cea7-4585-b3d3-71235eaa157b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("b654d383-0b5d-4fb6-bbe3-fac3bc8cbd82"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("c5a0cdb4-7337-4cf2-9cad-597ba4bfbde9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("eeec8085-5f27-4499-ab29-48b2cb2b548e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("f6d4dab6-0120-4938-886e-ea777ed60219"));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Roley_Employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creation",
                table: "Roley_Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Roley_Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Roley_Employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Roles_Departments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creation",
                table: "Roles_Departments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Roles_Departments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Roles_Departments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Product-Types_Product-Types",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creation",
                table: "Product-Types_Product-Types",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Product-Types_Product-Types",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Product-Types_Product-Types",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Product-Types_Orders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creation",
                table: "Product-Types_Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Product-Types_Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Product-Types_Orders",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Roley_Employees");

            migrationBuilder.DropColumn(
                name: "Creation",
                table: "Roley_Employees");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Roley_Employees");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Roley_Employees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Roles_Departments");

            migrationBuilder.DropColumn(
                name: "Creation",
                table: "Roles_Departments");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Roles_Departments");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Roles_Departments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Product-Types_Product-Types");

            migrationBuilder.DropColumn(
                name: "Creation",
                table: "Product-Types_Product-Types");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Product-Types_Product-Types");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Product-Types_Product-Types");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Product-Types_Orders");

            migrationBuilder.DropColumn(
                name: "Creation",
                table: "Product-Types_Orders");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Product-Types_Orders");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Product-Types_Orders");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("3cb00335-216a-4788-bae4-76d98a21fdbf"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(6247), "Employee from the logistics department", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(7032), "system", "Logistic" },
                    { new Guid("0f72beb1-997c-4913-806d-12cb27d1f438"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8080), "Employee from the finances department", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8091), "system", "Finance" },
                    { new Guid("b654d383-0b5d-4fb6-bbe3-fac3bc8cbd82"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8102), "Employee from the purchases department", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8104), "system", "Purchase" },
                    { new Guid("f6d4dab6-0120-4938-886e-ea777ed60219"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8108), "Administrators of the app", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8110), "system", "SysAdmin" },
                    { new Guid("69f70b9a-cea7-4585-b3d3-71235eaa157b"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8113), "Employee from the sales department", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8115), "system", "Sale" },
                    { new Guid("eeec8085-5f27-4499-ab29-48b2cb2b548e"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8120), "Employee from the management", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8122), "system", "Management" },
                    { new Guid("143dcc6f-9cd3-4191-9a84-e24378efd676"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8196), "Employee from the hr department", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8199), "system", "HR" },
                    { new Guid("c5a0cdb4-7337-4cf2-9cad-597ba4bfbde9"), "system", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8202), "Employee from the production department", new DateTime(2019, 5, 12, 19, 57, 37, 448, DateTimeKind.Local).AddTicks(8204), "system", "Production" }
                });
        }
    }
}
