using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CLERP.API.Migrations
{
    public partial class ReplacedRoleTypeWithName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Roles",
                newName: "Name");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "Type");
        }
    }
}
