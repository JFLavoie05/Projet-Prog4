using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class DTOFait : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a64f2dac-6e2e-492f-badf-135fcf88b006");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6cfb6d4-6a52-4575-a104-afcc825868a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b046d72b-f205-428b-b4a3-7ceb2d69ee57", null, "Admin", "ADMIN" },
                    { "c70e9032-750c-42dc-b047-c823eeccd3b0", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "a64f2dac-6e2e-492f-badf-135fcf88b006", null, "Admin", "ADMIN" },
                    { "c6cfb6d4-6a52-4575-a104-afcc825868a6", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
