using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class MovedImageFromProductToProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("05ea1cfa-0d1d-4d67-868b-5abec3818105"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("3e541866-5c8e-4fea-8c0a-212d767903de"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("b156c5eb-78e3-4345-97ac-00f29cdd31be"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("cdc29573-5a22-4869-828e-1b13250fe172"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("ce7ca901-9d9c-44da-a479-16875f464c7c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("d299cde1-6fd1-4168-8f3e-1fa4f2a607ba"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Guid",
                keyValue: new Guid("eafcbeb6-2fb0-402a-9d31-4f322dbfeab0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Guid",
                keyValue: new Guid("29c0a310-c859-476d-b614-546a7f4e85c7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("263aae9a-baad-4730-9388-4dbd39e2c7c8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("53ce70e3-73f2-4dcc-a857-0a7cfb875cee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("5b9ead8f-3a10-4e95-906b-f8c7190795de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("7b52c1f2-c13a-475a-8769-4b1be4c1c16d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("8517cf31-aec0-455e-a174-cd98fa048f07"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("b5b9a5a0-a6d6-4469-bc4a-7142728b94eb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("c624e9c2-84d3-4b95-91d7-5cde0865c34e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Guid",
                keyValue: new Guid("f2988ca5-e263-47e3-b9b5-40bd047243c6"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Product-Types",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Product-Types");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("cdc29573-5a22-4869-828e-1b13250fe172"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 122, DateTimeKind.Local).AddTicks(7392), "The management of the firm", new DateTime(2019, 5, 20, 22, 10, 25, 122, DateTimeKind.Local).AddTicks(8834), "system", "Management" },
                    { new Guid("05ea1cfa-0d1d-4d67-868b-5abec3818105"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(1950), "The finance department of the firm", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(1973), "system", "Finance" },
                    { new Guid("3e541866-5c8e-4fea-8c0a-212d767903de"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2005), "The hr department of the firm", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2010), "system", "HR" },
                    { new Guid("ce7ca901-9d9c-44da-a479-16875f464c7c"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2015), "The sales department of the firm", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2019), "system", "Sales" },
                    { new Guid("b156c5eb-78e3-4345-97ac-00f29cdd31be"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2024), "The purchase department of the firm", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2028), "system", "Purchase" },
                    { new Guid("d299cde1-6fd1-4168-8f3e-1fa4f2a607ba"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2036), "The logistics department of the firm", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2040), "system", "Logistic" },
                    { new Guid("eafcbeb6-2fb0-402a-9d31-4f322dbfeab0"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2045), "The production department of the firm", new DateTime(2019, 5, 20, 22, 10, 25, 123, DateTimeKind.Local).AddTicks(2048), "system", "Production" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Guid", "Birthday", "CreatedBy", "Creation", "DepartmentGuid", "Email", "Firstname", "LastModified", "LastModifiedBy", "Lastname", "Password", "PhoneNumber", "Username" },
                values: new object[] { new Guid("29c0a310-c859-476d-b614-546a7f4e85c7"), new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2019, 5, 20, 22, 10, 25, 128, DateTimeKind.Local).AddTicks(6148), null, "admin@clerp.ch", "System", new DateTime(2019, 5, 20, 22, 10, 25, 128, DateTimeKind.Local).AddTicks(8467), "system", "Administrator", "AI1ZmgGoYudgP1w9VOvAIAnobk5IXBU3wC/Pfv/Xyg0Mr9PEgJPW5UBP9ScXzpEiVg==", "+41 79 122 90 72", "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Guid", "CreatedBy", "Creation", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("5b9ead8f-3a10-4e95-906b-f8c7190795de"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 173, DateTimeKind.Local).AddTicks(8979), "Employee from the logistics department", new DateTime(2019, 5, 20, 22, 10, 25, 173, DateTimeKind.Local).AddTicks(9014), "system", "Logistic" },
                    { new Guid("f2988ca5-e263-47e3-b9b5-40bd047243c6"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(460), "Employee from the finances department", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(471), "system", "Finance" },
                    { new Guid("8517cf31-aec0-455e-a174-cd98fa048f07"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(488), "Employee from the purchases department", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(492), "system", "Purchase" },
                    { new Guid("7b52c1f2-c13a-475a-8769-4b1be4c1c16d"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(499), "Administrators of the app", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(502), "system", "SysAdmin" },
                    { new Guid("53ce70e3-73f2-4dcc-a857-0a7cfb875cee"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(507), "Employee from the sales department", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(511), "system", "Sale" },
                    { new Guid("c624e9c2-84d3-4b95-91d7-5cde0865c34e"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(519), "Employee from the management", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(523), "system", "Management" },
                    { new Guid("b5b9a5a0-a6d6-4469-bc4a-7142728b94eb"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(536), "Employee from the hr department", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(540), "system", "HR" },
                    { new Guid("263aae9a-baad-4730-9388-4dbd39e2c7c8"), "system", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(547), "Employee from the production department", new DateTime(2019, 5, 20, 22, 10, 25, 174, DateTimeKind.Local).AddTicks(550), "system", "Production" }
                });
        }
    }
}
