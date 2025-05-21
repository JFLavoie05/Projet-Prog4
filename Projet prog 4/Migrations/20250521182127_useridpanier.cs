using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class useridpanier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5cd56d4f-cb98-418c-847a-a292f33494da", null, "Admin", "ADMIN" },
                    { "aaf18775-0b4b-406c-9c8b-1260a17c090e", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cd56d4f-cb98-418c-847a-a292f33494da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaf18775-0b4b-406c-9c8b-1260a17c090e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85b66f92-4b44-4059-b21b-6c55c8cf7073", null, "Utilisateur", "UTILISATEUR" },
                    { "f76c13d1-9ebb-40d3-b6c7-4bf7823fa927", null, "Admin", "ADMIN" }
                });
        }
    }
}
