using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class logs4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f10b35c-33f7-4665-a66f-2a7ae40bf006");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff4ee014-244d-4196-ab89-6a0574624b4d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65952d91-2d8c-461e-b591-0a33041af0ee", null, "Admin", "ADMIN" },
                    { "9863a06d-93c1-422e-b495-b1d5f347d1ab", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65952d91-2d8c-461e-b591-0a33041af0ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9863a06d-93c1-422e-b495-b1d5f347d1ab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f10b35c-33f7-4665-a66f-2a7ae40bf006", null, "Utilisateur", "UTILISATEUR" },
                    { "ff4ee014-244d-4196-ab89-6a0574624b4d", null, "Admin", "ADMIN" }
                });
        }
    }
}
