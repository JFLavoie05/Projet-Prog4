using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class ajouteraupanier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e9d5e5a-8a7b-4bca-9ea3-0497d6415f0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc7e69a4-04a7-410c-8ac7-3b3cb1907c72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27d1f9bb-425f-4e12-bd6a-4c033c115002", null, "Admin", "ADMIN" },
                    { "d78111cf-0996-49fb-a126-319140fd6590", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "7e9d5e5a-8a7b-4bca-9ea3-0497d6415f0b", null, "Utilisateur", "UTILISATEUR" },
                    { "bc7e69a4-04a7-410c-8ac7-3b3cb1907c72", null, "Admin", "ADMIN" }
                });
        }
    }
}
