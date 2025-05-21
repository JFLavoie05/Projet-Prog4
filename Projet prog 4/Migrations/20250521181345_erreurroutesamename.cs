using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class erreurroutesamename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8da25b7c-6e32-496e-bdb4-3d1d99a5cbe4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adeb77ba-05b7-4819-9c72-d978e7d9550a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85b66f92-4b44-4059-b21b-6c55c8cf7073", null, "Utilisateur", "UTILISATEUR" },
                    { "f76c13d1-9ebb-40d3-b6c7-4bf7823fa927", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85b66f92-4b44-4059-b21b-6c55c8cf7073");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f76c13d1-9ebb-40d3-b6c7-4bf7823fa927");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8da25b7c-6e32-496e-bdb4-3d1d99a5cbe4", null, "Admin", "ADMIN" },
                    { "adeb77ba-05b7-4819-9c72-d978e7d9550a", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
