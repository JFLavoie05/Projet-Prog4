using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class reduirePrixPourStripe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "270ac1ae-ac3c-45d6-8105-318f7eb3fc73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9da30c93-013d-42fe-9dd5-5b0172e9a0aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a64f2dac-6e2e-492f-badf-135fcf88b006", null, "Admin", "ADMIN" },
                    { "c6cfb6d4-6a52-4575-a104-afcc825868a6", null, "Utilisateur", "UTILISATEUR" }
                });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 1,
                column: "Prix",
                value: 10000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 2,
                column: "Prix",
                value: 8000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 3,
                column: "Prix",
                value: 12000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 4,
                column: "Prix",
                value: 9500);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 5,
                column: "Prix",
                value: 7000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 6,
                column: "Prix",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 7,
                column: "Prix",
                value: 4500);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 8,
                column: "Prix",
                value: 3000);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a64f2dac-6e2e-492f-badf-135fcf88b006");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6cfb6d4-6a52-4575-a104-afcc825868a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "270ac1ae-ac3c-45d6-8105-318f7eb3fc73", null, "Utilisateur", "UTILISATEUR" },
                    { "9da30c93-013d-42fe-9dd5-5b0172e9a0aa", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 1,
                column: "Prix",
                value: 1000000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 2,
                column: "Prix",
                value: 800000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 3,
                column: "Prix",
                value: 1200000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 4,
                column: "Prix",
                value: 950000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 5,
                column: "Prix",
                value: 700000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 6,
                column: "Prix",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 7,
                column: "Prix",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 8,
                column: "Prix",
                value: 300000);
        }
    }
}
