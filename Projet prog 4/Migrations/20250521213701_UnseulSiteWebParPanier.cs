using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class UnseulSiteWebParPanier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "906caf81-c58e-4ded-babf-ee980dd13a93", null, "Admin", "ADMIN" },
                    { "e8cb414e-c4f6-42d9-886b-def8b993a09a", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "906caf81-c58e-4ded-babf-ee980dd13a93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8cb414e-c4f6-42d9-886b-def8b993a09a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "873ce883-d66f-4e54-b878-d51c3544e235", null, "Admin", "ADMIN" },
                    { "d1d6e2e8-37bc-44fc-8e15-125acb80ab53", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
