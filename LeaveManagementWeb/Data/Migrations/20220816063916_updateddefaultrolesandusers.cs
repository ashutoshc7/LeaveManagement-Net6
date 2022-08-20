using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class updateddefaultrolesandusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocation",
                table: "LeaveAllocation");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "866f4b79-dzf9-450b-8f9c-f467162a0ac2", "266f5b79-ddf9-450b-8f9c-d467162a0aa2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-450b-8f9c-f467162a0ac2");

            migrationBuilder.RenameTable(
                name: "LeaveAllocation",
                newName: "LeaveAllocations");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocation_LeaveTypeId",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "441743d4-b8a9-47e8-81c2-53802c79e718");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "866f4b79-dzf9-850g-8e5n-f467162a0ac2", "d4a152b6-f8d6-4e41-bb2c-588dbc2d46d6", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65792eea-6889-47f5-a6e2-2f9a6c94c0d6", "AQAAAAEAACcQAAAAELF0Af+OaHrTjnP0GOyOkad80bIKdO7UDQJ1OSEhickvxfQbQCqfp1T0QDnwtN7zkg==", "e03bfee5-510e-4cba-a782-328810b9a4d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f63e06a-77eb-473a-ada1-9506d081748c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c392df39-a866-430a-a4e3-b377e15702b8", "AQAAAAEAACcQAAAAEPc5foD5m4FsiAhnnSxP9YhL3qxYSdigx3+diD2xw9DOm6ZgWk48FIz/aeGETlOHPQ==", "223803b7-78b8-40a8-acde-29616ba0c5b7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "866f4b79-dzf9-850g-8e5n-f467162a0ac2", "266f5b79-ddf9-450b-8f9c-d467162a0aa2" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "866f4b79-dzf9-850g-8e5n-f467162a0ac2", "266f5b79-ddf9-450b-8f9c-d467162a0aa2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866f4b79-dzf9-850g-8e5n-f467162a0ac2");

            migrationBuilder.RenameTable(
                name: "LeaveAllocations",
                newName: "LeaveAllocation");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocation",
                newName: "IX_LeaveAllocation_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocation",
                table: "LeaveAllocation",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266f5b89-def9-450b-8f9c-d467162a0ab2",
                column: "ConcurrencyStamp",
                value: "818aa72c-3651-4f27-8dec-f0850630a384");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "866f4b79-dzf9-450b-8f9c-f467162a0ac2", "a31f612e-a8ae-4d7a-b143-7fae6ba7763f", "User", "USER" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "866f4b79-dzf9-450b-8f9c-f467162a0ac2", "266f5b79-ddf9-450b-8f9c-d467162a0aa2" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocation",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
