using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "4dbd94b7-47b8-424a-a739-51440e52f5a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2",
                column: "ConcurrencyStamp",
                value: "f457d709-1420-482a-8b5e-3993cc064a34");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4cf423ee-6d3e-4bab-9c17-97054fdd2615", true, "AQAAAAEAACcQAAAAENpceVWEDz6GkaVVsxTkqpFrhYqs2kUb0Biv5ji9IuVYtC7WsqIA8PX/USvtn0XklA==", "1215ad95-4388-4f6b-a9d4-5b2ad846d9b4", "ashuc@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "86114c25-07a8-4eb9-8f0b-0d208aef8c17", true, "AQAAAAEAACcQAAAAEMeTUOrg3pO2CeNZ6YFXRhHNMnskNWiQEkYgUsZVUxRzXPZHXXTxmB+syK0JHDYkIQ==", "37158c73-36ea-479a-9ed2-36fcde711cd0", "admin@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "414b5827-316f-4dea-b12b-677457a0a6aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2",
                column: "ConcurrencyStamp",
                value: "831563ed-db1e-4618-a75f-58b45a4261da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b4ca3683-1df3-4763-959f-b689e0db7e11", false, "AQAAAAEAACcQAAAAEBlof0bzSGdvpx4Pcx8O7ukVrj2vNQttzWdMlnRA9ad2ZrhJmb7HBiYTr0ROjVKgew==", "1c8fab14-bf7e-49d7-aaea-cd5771c8970c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0dbb73e7-8d01-4d7a-83b5-b9c63a4af6cb", false, "AQAAAAEAACcQAAAAENfWAYvCjQMJkzsqHTDH5Dx/vEK14opwWDv6IApjYxr9nsz92R0t6P8Ony29GUz/tA==", "1d7d469c-d9e9-49b2-86ef-8ea87f0bb781", null });
        }
    }
}
