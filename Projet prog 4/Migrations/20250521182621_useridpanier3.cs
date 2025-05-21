using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class useridpanier3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "7e9d5e5a-8a7b-4bca-9ea3-0497d6415f0b", null, "Utilisateur", "UTILISATEUR" },
                    { "bc7e69a4-04a7-410c-8ac7-3b3cb1907c72", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "79462c86-612d-487f-bb4d-589ea0e95007", null, "Admin", "ADMIN" },
                    { "97a34c50-537d-4401-800e-8adc709e3444", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
