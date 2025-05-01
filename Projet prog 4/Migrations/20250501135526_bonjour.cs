using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class bonjour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0523e2f4-0218-4f1a-8f1a-b771f9aec7c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09e717c1-d2b7-472d-883c-8a7b7743cb09");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Panier",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12733ad3-677e-4fc7-baa2-2d95403bb8fb", null, "Admin", "ADMIN" },
                    { "b1008ba1-c211-4e15-9734-17cea1d3deb9", null, "Utilisateur", "UTILISATEUR" }
                });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "NbRestant", "Prix" },
                values: new object[] { "Description SiteWeb1", 500, "100000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "NbRestant", "Prix" },
                values: new object[] { "Description SiteWeb2", 1000, "500000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "NbRestant", "Prix" },
                values: new object[] { "Description SiteWeb3", 2000, "600000" });

            migrationBuilder.InsertData(
                table: "SiteWeb",
                columns: new[] { "Id", "Description", "Image", "Lien", "NbRestant", "Nom", "PanierId", "Prix" },
                values: new object[,]
                {
                    { 4, "Description SiteWeb4", null, null, 100, "SiteWeb4", null, "300000" },
                    { 5, "Description SiteWeb5", null, null, 8000, "SiteWeb5", null, "200000" },
                    { 6, "Description SiteWeb6", null, null, 4000, "SiteWeb6", null, "800000" },
                    { 7, "Description SiteWeb7", null, null, 800, "SiteWeb7", null, "1000000" },
                    { 8, "Description SiteWeb8", null, null, 1500, "SiteWeb8", null, "900000" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12733ad3-677e-4fc7-baa2-2d95403bb8fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1008ba1-c211-4e15-9734-17cea1d3deb9");

            migrationBuilder.DeleteData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Panier");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0523e2f4-0218-4f1a-8f1a-b771f9aec7c2", null, "Utilisateur", "UTILISATEUR" },
                    { "09e717c1-d2b7-472d-883c-8a7b7743cb09", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "NbRestant", "Prix" },
                values: new object[] { null, 0, null });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "NbRestant", "Prix" },
                values: new object[] { null, 0, null });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "NbRestant", "Prix" },
                values: new object[] { null, 0, null });
        }
    }
}
