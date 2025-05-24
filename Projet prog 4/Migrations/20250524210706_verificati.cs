using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class verificati : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5648fb62-247c-4674-8fa7-22b82847dc74", null, "Utilisateur", "UTILISATEUR" },
                    { "74b1eee6-ebdd-47a0-a45b-e98d633a9ad9", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5648fb62-247c-4674-8fa7-22b82847dc74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74b1eee6-ebdd-47a0-a45b-e98d633a9ad9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ac9c24f9-a09b-4313-aaa4-dbe4936f05ad", null, "Admin", "ADMIN" },
                    { "db0fe3ff-83b0-4603-9a4f-4bea4df19a90", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
