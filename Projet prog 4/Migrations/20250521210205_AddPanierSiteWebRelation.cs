using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_prog_4.Migrations
{
    /// <inheritdoc />
    public partial class AddPanierSiteWebRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteWeb_Panier_PanierId",
                table: "SiteWeb");

            migrationBuilder.DropIndex(
                name: "IX_SiteWeb_PanierId",
                table: "SiteWeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "003991c9-d298-4495-9f76-308ad6a445b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1d95435-3286-4314-b46c-57558771803d");

            migrationBuilder.DropColumn(
                name: "PanierId",
                table: "SiteWeb");

            migrationBuilder.AlterColumn<int>(
                name: "Prix",
                table: "SiteWeb",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PanierSiteWeb",
                columns: table => new
                {
                    PanierId = table.Column<int>(type: "int", nullable: false),
                    SiteWebId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanierSiteWeb", x => new { x.PanierId, x.SiteWebId });
                    table.ForeignKey(
                        name: "FK_PanierSiteWeb_Panier_PanierId",
                        column: x => x.PanierId,
                        principalTable: "Panier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PanierSiteWeb_SiteWeb_SiteWebId",
                        column: x => x.SiteWebId,
                        principalTable: "SiteWeb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c0b5623-1c04-40df-a946-119a873aa72a", null, "Utilisateur", "UTILISATEUR" },
                    { "e9126196-2de2-439e-a7bf-ced7ae134a36", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 1,
                column: "Prix",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 2,
                column: "Prix",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 3,
                column: "Prix",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 4,
                column: "Prix",
                value: 300000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 5,
                column: "Prix",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 6,
                column: "Prix",
                value: 800000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 7,
                column: "Prix",
                value: 1000000);

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 8,
                column: "Prix",
                value: 900000);

            migrationBuilder.CreateIndex(
                name: "IX_PanierSiteWeb_SiteWebId",
                table: "PanierSiteWeb",
                column: "SiteWebId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PanierSiteWeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c0b5623-1c04-40df-a946-119a873aa72a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9126196-2de2-439e-a7bf-ced7ae134a36");

            migrationBuilder.AlterColumn<string>(
                name: "Prix",
                table: "SiteWeb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PanierId",
                table: "SiteWeb",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "003991c9-d298-4495-9f76-308ad6a445b0", null, "Utilisateur", "UTILISATEUR" },
                    { "a1d95435-3286-4314-b46c-57558771803d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "100000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "500000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "600000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "300000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "200000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "800000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "1000000" });

            migrationBuilder.UpdateData(
                table: "SiteWeb",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PanierId", "Prix" },
                values: new object[] { null, "900000" });

            migrationBuilder.CreateIndex(
                name: "IX_SiteWeb_PanierId",
                table: "SiteWeb",
                column: "PanierId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteWeb_Panier_PanierId",
                table: "SiteWeb",
                column: "PanierId",
                principalTable: "Panier",
                principalColumn: "Id");
        }
    }
}
