using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class commandeConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12733ad3-677e-4fc7-baa2-2d95403bb8fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1008ba1-c211-4e15-9734-17cea1d3deb9");

            migrationBuilder.AddColumn<int>(
                name: "CommandeId",
                table: "SiteWeb",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f91867d-49bd-424a-b488-c6cf4f483df3", null, "Utilisateur", "UTILISATEUR" },
                    { "6bf4ec95-334d-457a-a338-1095f7adc29c", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommandeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommandeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommandeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommandeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 5,
                column: "CommandeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 6,
                column: "CommandeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 7,
                column: "CommandeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 8,
                column: "CommandeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_SiteWeb_CommandeId",
                table: "SiteWeb",
                column: "CommandeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteWeb_Commande_CommandeId",
                table: "SiteWeb",
                column: "CommandeId",
                principalTable: "Commande",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteWeb_Commande_CommandeId",
                table: "SiteWeb");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropIndex(
                name: "IX_SiteWeb_CommandeId",
                table: "SiteWeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f91867d-49bd-424a-b488-c6cf4f483df3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bf4ec95-334d-457a-a338-1095f7adc29c");

            migrationBuilder.DropColumn(
                name: "CommandeId",
                table: "SiteWeb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12733ad3-677e-4fc7-baa2-2d95403bb8fb", null, "Admin", "ADMIN" },
                    { "b1008ba1-c211-4e15-9734-17cea1d3deb9", null, "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
