using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLERP.API.Migrations
{
    public partial class AddedSystemAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
