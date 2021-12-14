using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("dfebd283-b105-410c-bf66-6c162f85c927"),
                column: "ConcurrencyStamp",
                value: "73501214-9398-4cf5-9a47-7c713f2e5c36");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aacd418d-46f4-4175-b6b7-9f2d42993fa6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e72c8aa-7a95-42d6-b608-8e2c1917390b", "AQAAAAEAACcQAAAAENnDzmd9hlzsAXggPUGyaYZMVHaQ2uQUngrcdz2EJi5MAcPO9OkyXz8adG7IpkNtEw==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 14, 11, 24, 5, 624, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("dfebd283-b105-410c-bf66-6c162f85c927"),
                column: "ConcurrencyStamp",
                value: "5d56578b-3223-47f9-bb8d-84188dd4fc89");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("aacd418d-46f4-4175-b6b7-9f2d42993fa6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "531627b8-bdaf-4194-bdce-a956297ae4e2", "AQAAAAEAACcQAAAAEJfsOOdWEZZDogbUMpIbBxBdu0/WfaOsGXXbWQUk7r7PzEIMiufjDxcR986xRHVKsQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 12, 16, 14, 42, 961, DateTimeKind.Local).AddTicks(6297));
        }
    }
}
