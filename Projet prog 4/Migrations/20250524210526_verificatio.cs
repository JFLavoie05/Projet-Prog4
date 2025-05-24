using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class verificatio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "ac9c24f9-a09b-4313-aaa4-dbe4936f05ad", null, "Admin", "ADMIN" },
                    { "db0fe3ff-83b0-4603-9a4f-4bea4df19a90", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac9c24f9-a09b-4313-aaa4-dbe4936f05ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db0fe3ff-83b0-4603-9a4f-4bea4df19a90");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0bdb8570-be4c-4049-823f-82326bdf6df8", null, "Utilisateur", "UTILISATEUR" },
                    { "0f21b744-3b80-45d7-8e5a-33fd7fc8ba87", null, "Admin", "ADMIN" }
                });
        }
    }
}
