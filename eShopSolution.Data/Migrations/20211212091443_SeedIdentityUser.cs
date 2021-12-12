using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("dfebd283-b105-410c-bf66-6c162f85c927"), "5d56578b-3223-47f9-bb8d-84188dd4fc89", "Admin Role", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("dfebd283-b105-410c-bf66-6c162f85c927"), new Guid("aacd418d-46f4-4175-b6b7-9f2d42993fa6") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("aacd418d-46f4-4175-b6b7-9f2d42993fa6"), 0, "531627b8-bdaf-4194-bdce-a956297ae4e2", new DateTime(2000, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Huy", "Nguyen", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEJfsOOdWEZZDogbUMpIbBxBdu0/WfaOsGXXbWQUk7r7PzEIMiufjDxcR986xRHVKsQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 12, 16, 14, 42, 961, DateTimeKind.Local).AddTicks(6297));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("dfebd283-b105-410c-bf66-6c162f85c927"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("dfebd283-b105-410c-bf66-6c162f85c927"), new Guid("aacd418d-46f4-4175-b6b7-9f2d42993fa6") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aacd418d-46f4-4175-b6b7-9f2d42993fa6"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 12, 15, 51, 9, 68, DateTimeKind.Local).AddTicks(6949));
        }
    }
}
