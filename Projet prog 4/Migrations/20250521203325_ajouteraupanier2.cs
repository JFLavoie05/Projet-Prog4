using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class ajouteraupanier2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27d1f9bb-425f-4e12-bd6a-4c033c115002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d78111cf-0996-49fb-a126-319140fd6590");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "003991c9-d298-4495-9f76-308ad6a445b0", null, "Utilisateur", "UTILISATEUR" },
                    { "a1d95435-3286-4314-b46c-57558771803d", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "003991c9-d298-4495-9f76-308ad6a445b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1d95435-3286-4314-b46c-57558771803d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27d1f9bb-425f-4e12-bd6a-4c033c115002", null, "Admin", "ADMIN" },
                    { "d78111cf-0996-49fb-a126-319140fd6590", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
