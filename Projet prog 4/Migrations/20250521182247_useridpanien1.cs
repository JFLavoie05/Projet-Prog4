using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class useridpanien1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "79462c86-612d-487f-bb4d-589ea0e95007", null, "Admin", "ADMIN" },
                    { "97a34c50-537d-4401-800e-8adc709e3444", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79462c86-612d-487f-bb4d-589ea0e95007");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97a34c50-537d-4401-800e-8adc709e3444");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5cd56d4f-cb98-418c-847a-a292f33494da", null, "Admin", "ADMIN" },
                    { "aaf18775-0b4b-406c-9c8b-1260a17c090e", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
