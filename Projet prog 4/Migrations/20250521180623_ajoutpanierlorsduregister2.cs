using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class ajoutpanierlorsduregister2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "892448ae-5ce9-425f-8cc9-f79118e77dbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "998220b1-3017-4f93-9ab4-d58e14d51e96");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8da25b7c-6e32-496e-bdb4-3d1d99a5cbe4", null, "Admin", "ADMIN" },
                    { "adeb77ba-05b7-4819-9c72-d978e7d9550a", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8da25b7c-6e32-496e-bdb4-3d1d99a5cbe4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adeb77ba-05b7-4819-9c72-d978e7d9550a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "892448ae-5ce9-425f-8cc9-f79118e77dbb", null, "Admin", "ADMIN" },
                    { "998220b1-3017-4f93-9ab4-d58e14d51e96", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
