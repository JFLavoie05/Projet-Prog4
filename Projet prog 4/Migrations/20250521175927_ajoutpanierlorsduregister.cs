using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class ajoutpanierlorsduregister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f91867d-49bd-424a-b488-c6cf4f483df3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bf4ec95-334d-457a-a338-1095f7adc29c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7099ede5-d5df-493f-85d5-f49b5a4556e4", null, "Utilisateur", "UTILISATEUR" },
                    { "b5bb660e-e1e4-4e43-88ae-32510a310867", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7099ede5-d5df-493f-85d5-f49b5a4556e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5bb660e-e1e4-4e43-88ae-32510a310867");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f91867d-49bd-424a-b488-c6cf4f483df3", null, "Utilisateur", "UTILISATEUR" },
                    { "6bf4ec95-334d-457a-a338-1095f7adc29c", null, "Admin", "ADMIN" }
                });
        }
    }
}
