using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "period",
                table: "LeaveAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "87aa79c8-9102-4f5a-981a-7a2e4688dd82", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2",
                column: "ConcurrencyStamp",
                value: "e32fd957-d925-44ca-bcc6-3e5b2eaad86a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "212ff7dc-1cd1-4513-a9d8-b7ab4973d81e", "AQAAAAEAACcQAAAAEN1nHeZNln1FGa6gDJAHcHkOCP5962hYpD5lzd/cYhn5zUn9L3QNJxW/bv1zTgjvGw==", "0958cf28-41a8-44af-9842-7c9c9f83c6d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "348058df-988e-464e-9c8f-8c85540228d6", "AQAAAAEAACcQAAAAEM1lQf6zTYPBZV7q14CW6weDy9uG35rnY/dSM8YrygTtDq5Fpyn0EXa2I8uio1nnJQ==", "0c9af6c6-bd95-4463-9920-c723ea1c622f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "period",
                table: "LeaveAllocation");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "cf8c1d95-d004-419c-8e15-a0625d793b62", "Aministrator" });

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
    }
}
