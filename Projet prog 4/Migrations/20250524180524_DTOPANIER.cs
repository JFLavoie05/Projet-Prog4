using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class DTOPANIER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b046d72b-f205-428b-b4a3-7ceb2d69ee57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c70e9032-750c-42dc-b047-c823eeccd3b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62ab6d7b-c068-4115-8ed5-e4d81ff38c73", null, "Admin", "ADMIN" },
                    { "e657a277-4671-4bfe-a5e2-12e0c46f0ffa", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "b046d72b-f205-428b-b4a3-7ceb2d69ee57", null, "Admin", "ADMIN" },
                    { "c70e9032-750c-42dc-b047-c823eeccd3b0", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
