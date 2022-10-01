using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class UpdateTim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurnirId = table.Column<int>(type: "int", nullable: false),
                    BrojBodova = table.Column<int>(type: "int", nullable: false),
                    BrojPobjeda = table.Column<int>(type: "int", nullable: false),
                    BrojNerijesenih = table.Column<int>(type: "int", nullable: false),
                    BrojPoraza = table.Column<int>(type: "int", nullable: false),
                    BrojDatihGolova = table.Column<int>(type: "int", nullable: false),
                    BrojPrimljenihGolova = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tims_Turnirs_TurnirId",
                        column: x => x.TurnirId,
                        principalTable: "Turnirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tims_TurnirId",
                table: "Tims",
                column: "TurnirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tims");
        }
    }
}
