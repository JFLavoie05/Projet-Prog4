using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class logs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca6d1033-c502-4952-9fcc-918ebd09d4bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d86665b1-5a40-466c-b60d-eb8951487c5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12557e53-1fb4-4f87-93f4-8feafcda7a57", null, "Admin", "ADMIN" },
                    { "cc629669-f237-4cff-8ba0-d208fdbb986a", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12557e53-1fb4-4f87-93f4-8feafcda7a57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc629669-f237-4cff-8ba0-d208fdbb986a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca6d1033-c502-4952-9fcc-918ebd09d4bc", null, "Admin", "ADMIN" },
                    { "d86665b1-5a40-466c-b60d-eb8951487c5a", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
