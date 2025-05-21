using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class ajoutpanierlorsduregister1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7099ede5-d5df-493f-85d5-f49b5a4556e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5bb660e-e1e4-4e43-88ae-32510a310867");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "892448ae-5ce9-425f-8cc9-f79118e77dbb", null, "Admin", "ADMIN" },
                    { "998220b1-3017-4f93-9ab4-d58e14d51e96", null, "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "7099ede5-d5df-493f-85d5-f49b5a4556e4", null, "Utilisateur", "UTILISATEUR" },
                    { "b5bb660e-e1e4-4e43-88ae-32510a310867", null, "Admin", "ADMIN" }
                });
        }
    }
}
