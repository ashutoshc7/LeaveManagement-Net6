using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefautUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "266f5b89-def9-450b-8f9c-d467162a0ab2", "414b5827-316f-4dea-b12b-677457a0a6aa", "Aministrator", "ADMINISTRATOR" },
                    { "866f4b79-dzf9-450b-8f9c-f467162a0ac2", "831563ed-db1e-4618-a75f-58b45a4261da", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "266f5b79-ddf9-450b-8f9c-d467162a0aa2", 0, "b4ca3683-1df3-4763-959f-b689e0db7e11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ashuc@gmail.com", false, "Ashutosh", "Chaudhary", false, null, "ASHUC@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBlof0bzSGdvpx4Pcx8O7ukVrj2vNQttzWdMlnRA9ad2ZrhJmb7HBiYTr0ROjVKgew==", null, false, "1c8fab14-bf7e-49d7-aaea-cd5771c8970c", null, false, null },
                    { "8f63e06a-77eb-473a-ada1-9506d081748c", 0, "0dbb73e7-8d01-4d7a-83b5-b9c63a4af6cb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "Aman", "Mishra", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAENfWAYvCjQMJkzsqHTDH5Dx/vEK14opwWDv6IApjYxr9nsz92R0t6P8Ony29GUz/tA==", null, false, "1d7d469c-d9e9-49b2-86ef-8ea87f0bb781", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "866f4b79-dzf9-450b-8f9c-f467162a0ac2", "266f5b79-ddf9-450b-8f9c-d467162a0aa2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "266f5b89-def9-450b-8f9c-d467162a0ab2", "8f63e06a-77eb-473a-ada1-9506d081748c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "866f4b79-dzf9-450b-8f9c-f467162a0ac2", "266f5b79-ddf9-450b-8f9c-d467162a0aa2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "266f5b89-def9-450b-8f9c-d467162a0ab2", "8f63e06a-77eb-473a-ada1-9506d081748c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c");
        }
    }
}
