using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class log3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46cd4699-7b7d-40ba-8fea-7e6a8931d992");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a8589d-0887-483d-9464-5408c1b9ac17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f10b35c-33f7-4665-a66f-2a7ae40bf006", null, "Utilisateur", "UTILISATEUR" },
                    { "ff4ee014-244d-4196-ab89-6a0574624b4d", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "46cd4699-7b7d-40ba-8fea-7e6a8931d992", null, "Utilisateur", "UTILISATEUR" },
                    { "96a8589d-0887-483d-9464-5408c1b9ac17", null, "Admin", "ADMIN" }
                });
        }
    }
}
