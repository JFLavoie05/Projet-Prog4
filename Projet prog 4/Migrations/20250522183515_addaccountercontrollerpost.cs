using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class addaccountercontrollerpost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c20a7d9-54a5-4ca5-a1e7-c6b1cfc6691b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c99cc3d-b510-4467-a8c6-21ff4f319a30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7af81197-4404-4d4e-8c81-ed33b73de9a4", null, "Admin", "ADMIN" },
                    { "cad0b064-ede1-4e7f-90f2-419494323ffa", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7af81197-4404-4d4e-8c81-ed33b73de9a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cad0b064-ede1-4e7f-90f2-419494323ffa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c20a7d9-54a5-4ca5-a1e7-c6b1cfc6691b", null, "Utilisateur", "UTILISATEUR" },
                    { "8c99cc3d-b510-4467-a8c6-21ff4f319a30", null, "Admin", "ADMIN" }
                });
        }
    }
}
