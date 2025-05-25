using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class CommandeDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a3aedde-e644-4da6-bfff-44cef23e3e90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f588718-c280-434a-a777-82638cb1c1b9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70192bf9-bf5e-4ca0-a56b-ab2509a5d11a", null, "Admin", "ADMIN" },
                    { "d454a18c-7f04-42dc-b6d2-18d52e436501", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70192bf9-bf5e-4ca0-a56b-ab2509a5d11a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d454a18c-7f04-42dc-b6d2-18d52e436501");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a3aedde-e644-4da6-bfff-44cef23e3e90", null, "Utilisateur", "UTILISATEUR" },
                    { "3f588718-c280-434a-a777-82638cb1c1b9", null, "Admin", "ADMIN" }
                });
        }
    }
}
