using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class verification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65952d91-2d8c-461e-b591-0a33041af0ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9863a06d-93c1-422e-b495-b1d5f347d1ab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0bdb8570-be4c-4049-823f-82326bdf6df8", null, "Utilisateur", "UTILISATEUR" },
                    { "0f21b744-3b80-45d7-8e5a-33fd7fc8ba87", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bdb8570-be4c-4049-823f-82326bdf6df8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f21b744-3b80-45d7-8e5a-33fd7fc8ba87");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65952d91-2d8c-461e-b591-0a33041af0ee", null, "Admin", "ADMIN" },
                    { "9863a06d-93c1-422e-b495-b1d5f347d1ab", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
