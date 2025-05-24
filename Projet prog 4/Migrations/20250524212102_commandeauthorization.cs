using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class commandeauthorization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20fe0e1c-67b1-4655-85ab-801e589a0db6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "317d331a-00b1-409e-aa26-06efb8773a17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a3aedde-e644-4da6-bfff-44cef23e3e90", null, "Utilisateur", "UTILISATEUR" },
                    { "3f588718-c280-434a-a777-82638cb1c1b9", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "20fe0e1c-67b1-4655-85ab-801e589a0db6", null, "Utilisateur", "UTILISATEUR" },
                    { "317d331a-00b1-409e-aa26-06efb8773a17", null, "Admin", "ADMIN" }
                });
        }
    }
}
