using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class RoleNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "c540b14c-1d41-4ab4-b2ed-2606a0be5bf0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "f71697df-d30b-44fc-8846-df1b639ea15b", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dab27e5-fd33-4ad7-b04b-8759d84effdc", "AQAAAAEAACcQAAAAEHJaQP/MECRUBEHcbANRs0zOoSPv/7edrQ/D9blNjfyTqVvS+/ZbjBhVml7bl2zYqg==", "72d8ddd3-f2c6-4064-9b62-0c50eb70babb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d0777b-d8e1-4143-9d8b-9ee2d05810d2", "AQAAAAEAACcQAAAAEID3A+dCxh4UL8az9V4ySEmcm/TCI/lM/E4IhMx/YgZuHEJpSEtgLt7D4Bo+pZ0XUQ==", "ccee63de-3673-4d2a-b35e-5c856cd7936b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "f457d709-1420-482a-8b5e-3993cc064a34", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cf423ee-6d3e-4bab-9c17-97054fdd2615", "AQAAAAEAACcQAAAAENpceVWEDz6GkaVVsxTkqpFrhYqs2kUb0Biv5ji9IuVYtC7WsqIA8PX/USvtn0XklA==", "1215ad95-4388-4f6b-a9d4-5b2ad846d9b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86114c25-07a8-4eb9-8f0b-0d208aef8c17", "AQAAAAEAACcQAAAAEMeTUOrg3pO2CeNZ6YFXRhHNMnskNWiQEkYgUsZVUxRzXPZHXXTxmB+syK0JHDYkIQ==", "37158c73-36ea-479a-9ed2-36fcde711cd0" });
        }
    }
}
