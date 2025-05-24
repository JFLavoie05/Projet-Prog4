using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class verificat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "20fe0e1c-67b1-4655-85ab-801e589a0db6", null, "Utilisateur", "UTILISATEUR" },
                    { "317d331a-00b1-409e-aa26-06efb8773a17", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20fe0e1c-67b1-4655-85ab-801e589a0db6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "317d331a-00b1-409e-aa26-06efb8773a17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5648fb62-247c-4674-8fa7-22b82847dc74", null, "Utilisateur", "UTILISATEUR" },
                    { "74b1eee6-ebdd-47a0-a45b-e98d633a9ad9", null, "Admin", "ADMIN" }
                });
        }
    }
}
