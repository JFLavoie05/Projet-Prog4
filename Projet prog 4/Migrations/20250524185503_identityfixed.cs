using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class identityfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "7e019492-4e36-4d68-a674-d1b9ec336f7e", null, "Utilisateur", "UTILISATEUR" },
                    { "d7ba9972-64f2-43dd-a7d4-8177f7ef2b37", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e019492-4e36-4d68-a674-d1b9ec336f7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7ba9972-64f2-43dd-a7d4-8177f7ef2b37");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03fe5629-f932-45c3-837d-8cb6928e2b4c", null, "Admin", "ADMIN" },
                    { "94026620-86f2-4c80-a14b-cd23d531525c", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
