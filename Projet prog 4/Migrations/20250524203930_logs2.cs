using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class logs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "46cd4699-7b7d-40ba-8fea-7e6a8931d992", null, "Utilisateur", "UTILISATEUR" },
                    { "96a8589d-0887-483d-9464-5408c1b9ac17", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46cd4699-7b7d-40ba-8fea-7e6a8931d992");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a8589d-0887-483d-9464-5408c1b9ac17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12557e53-1fb4-4f87-93f4-8feafcda7a57", null, "Admin", "ADMIN" },
                    { "cc629669-f237-4cff-8ba0-d208fdbb986a", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
