using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class addanonymousaccountcontroller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "47152500-eeea-43f7-bef3-1137ae423092", null, "Utilisateur", "UTILISATEUR" },
                    { "e6cf8887-bdc1-4db8-9e54-030c5fa69304", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "7e019492-4e36-4d68-a674-d1b9ec336f7e", null, "Utilisateur", "UTILISATEUR" },
                    { "d7ba9972-64f2-43dd-a7d4-8177f7ef2b37", null, "Admin", "ADMIN" }
                });
        }
    }
}
