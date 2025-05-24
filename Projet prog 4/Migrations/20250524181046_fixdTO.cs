using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class fixdTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62ab6d7b-c068-4115-8ed5-e4d81ff38c73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e657a277-4671-4bfe-a5e2-12e0c46f0ffa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c35d69b-c566-47f3-8d94-d9056bce442f", null, "Admin", "ADMIN" },
                    { "60872dcb-341a-47c1-9ebf-55ab5b346739", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "62ab6d7b-c068-4115-8ed5-e4d81ff38c73", null, "Admin", "ADMIN" },
                    { "e657a277-4671-4bfe-a5e2-12e0c46f0ffa", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
