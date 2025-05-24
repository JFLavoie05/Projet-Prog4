using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class authorizefait : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c35d69b-c566-47f3-8d94-d9056bce442f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60872dcb-341a-47c1-9ebf-55ab5b346739");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03fe5629-f932-45c3-837d-8cb6928e2b4c", null, "Admin", "ADMIN" },
                    { "94026620-86f2-4c80-a14b-cd23d531525c", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03fe5629-f932-45c3-837d-8cb6928e2b4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94026620-86f2-4c80-a14b-cd23d531525c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c35d69b-c566-47f3-8d94-d9056bce442f", null, "Admin", "ADMIN" },
                    { "60872dcb-341a-47c1-9ebf-55ab5b346739", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
