using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class typoupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveId",
                table: "LeaveAllocation");

            migrationBuilder.RenameColumn(
                name: "period",
                table: "LeaveAllocation",
                newName: "Period");

            migrationBuilder.RenameColumn(
                name: "LeaveId",
                table: "LeaveAllocation",
                newName: "LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocation_LeaveId",
                table: "LeaveAllocation",
                newName: "IX_LeaveAllocation_LeaveTypeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "818aa72c-3651-4f27-8dec-f0850630a384");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2",
                column: "ConcurrencyStamp",
                value: "a31f612e-a8ae-4d7a-b143-7fae6ba7763f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf1a3f7f-2ef6-43ea-a714-c7ac6a2e8740", "AQAAAAEAACcQAAAAEKDuKbBhTqLhIo1xl0oMRgb5FBCIdx0jhMvGPpYnskaCTWbXeONsC5wyc/BaDnO5yw==", "271f5183-a8f3-4dc6-a7ea-014ff37f3891" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2410f53-0be2-475d-b763-8ea82fac8f08", "AQAAAAEAACcQAAAAEKZ1i5N2MfISlPSP/R8HphL3xg1zuvFcmWCsktdExCdihmvP2lr7X3yUWIWZEBcjfg==", "e69fb7b2-6f7a-4cd0-b750-e8b16fdbd8be" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocation",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocation");

            migrationBuilder.RenameColumn(
                name: "Period",
                table: "LeaveAllocation",
                newName: "period");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeId",
                table: "LeaveAllocation",
                newName: "LeaveId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocation_LeaveTypeId",
                table: "LeaveAllocation",
                newName: "IX_LeaveAllocation_LeaveId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "87aa79c8-9102-4f5a-981a-7a2e4688dd82");

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

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveId",
                table: "LeaveAllocation",
                column: "LeaveId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
