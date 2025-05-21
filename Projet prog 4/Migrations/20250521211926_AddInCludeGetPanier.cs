using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class AddInCludeGetPanier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c0b5623-1c04-40df-a946-119a873aa72a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9126196-2de2-439e-a7bf-ced7ae134a36");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "873ce883-d66f-4e54-b878-d51c3544e235", null, "Admin", "ADMIN" },
                    { "d1d6e2e8-37bc-44fc-8e15-125acb80ab53", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "873ce883-d66f-4e54-b878-d51c3544e235");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1d6e2e8-37bc-44fc-8e15-125acb80ab53");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c0b5623-1c04-40df-a946-119a873aa72a", null, "Utilisateur", "UTILISATEUR" },
                    { "e9126196-2de2-439e-a7bf-ced7ae134a36", null, "Admin", "ADMIN" }
                });
        }
    }
}
