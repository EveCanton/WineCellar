using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosCataYRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Catas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Invitados = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CataWine",
                columns: table => new
                {
                    CataId = table.Column<int>(type: "INTEGER", nullable: false),
                    WinesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CataWine", x => new { x.CataId, x.WinesId });
                    table.ForeignKey(
                        name: "FK_CataWine_Catas_CataId",
                        column: x => x.CataId,
                        principalTable: "Catas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CataWine_Wines_WinesId",
                        column: x => x.WinesId,
                        principalTable: "Wines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Rol", "UserName" },
                values: new object[,]
                {
                    { 1, "Pa$$w0rd", 0, "karenbailapiola@gmail.com" },
                    { 2, "SecureP@ss", 0, "juanperez@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Wines",
                columns: new[] { "Id", "CreatedAt", "Name", "Region", "Stock", "Variety", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 20, 3, 54, 16, 497, DateTimeKind.Utc).AddTicks(8098), "Cabernet Sauvignon", "Mendoza", 50, "Cabernet Sauvignon", 2018 },
                    { 2, new DateTime(2024, 10, 20, 3, 54, 16, 497, DateTimeKind.Utc).AddTicks(8103), "Malbec", "Mendoza", 30, "Malbec", 2020 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CataWine_WinesId",
                table: "CataWine",
                column: "WinesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CataWine");

            migrationBuilder.DropTable(
                name: "Catas");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");
        }
    }
}
