using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class addadmin123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "906caf81-c58e-4ded-babf-ee980dd13a93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8cb414e-c4f6-42d9-886b-def8b993a09a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c20a7d9-54a5-4ca5-a1e7-c6b1cfc6691b", null, "Utilisateur", "UTILISATEUR" },
                    { "8c99cc3d-b510-4467-a8c6-21ff4f319a30", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "906caf81-c58e-4ded-babf-ee980dd13a93", null, "Admin", "ADMIN" },
                    { "e8cb414e-c4f6-42d9-886b-def8b993a09a", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
