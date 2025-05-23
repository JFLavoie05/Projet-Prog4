using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class authemanagerADDCLAIM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7af81197-4404-4d4e-8c81-ed33b73de9a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cad0b064-ede1-4e7f-90f2-419494323ffa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16b2d354-2f50-4d01-8dbf-4d28561268cf", null, "Utilisateur", "UTILISATEUR" },
                    { "ff0e8615-6dc9-43f9-a5b4-2fca630c91ac", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16b2d354-2f50-4d01-8dbf-4d28561268cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff0e8615-6dc9-43f9-a5b4-2fca630c91ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7af81197-4404-4d4e-8c81-ed33b73de9a4", null, "Admin", "ADMIN" },
                    { "cad0b064-ede1-4e7f-90f2-419494323ffa", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
