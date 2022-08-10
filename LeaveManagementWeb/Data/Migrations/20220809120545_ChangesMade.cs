using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class ChangesMade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "cf8c1d95-d004-419c-8e15-a0625d793b62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2",
                column: "ConcurrencyStamp",
                value: "d7e90d5c-464b-4ce8-81e0-4242ea538863");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f18ddc74-5dd7-46e2-8e67-c8f579bbbae5", "AQAAAAEAACcQAAAAEJHwj21VmKQ53SaCvQEzC89ceYkCuzT+BmAA5TM6TyWbv8B48L+EG5hyAST1Y08tUw==", "686d35e8-645d-4556-81fa-8d517c213574" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5047085f-992d-47b1-ada7-c0289d3c7a00", "AQAAAAEAACcQAAAAEOlsO9Xm3pUZUDIFjHKjh0luIkKpHa8sVqiD1ha8C+OSeGStgOnl526whkhN6LQX0g==", "3b8a01ef-718c-4b96-95f0-deecb2dc2bbb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "ConcurrencyStamp",
                value: "f71697df-d30b-44fc-8846-df1b639ea15b");

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
    }
}
