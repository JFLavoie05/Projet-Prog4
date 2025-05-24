using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class idnetityproblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47152500-eeea-43f7-bef3-1137ae423092");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6cf8887-bdc1-4db8-9e54-030c5fa69304");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d72ad07-111f-4180-9baf-6f79f653e913", null, "Admin", "ADMIN" },
                    { "9ca87743-e677-4abe-8999-a01b8c68a1fa", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d72ad07-111f-4180-9baf-6f79f653e913");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ca87743-e677-4abe-8999-a01b8c68a1fa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47152500-eeea-43f7-bef3-1137ae423092", null, "Utilisateur", "UTILISATEUR" },
                    { "e6cf8887-bdc1-4db8-9e54-030c5fa69304", null, "Admin", "ADMIN" }
                });
        }
    }
}
