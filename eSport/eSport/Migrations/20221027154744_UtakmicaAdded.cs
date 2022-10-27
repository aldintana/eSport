using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class UtakmicaAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utakmicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomacinId = table.Column<int>(type: "int", nullable: false),
                    GostId = table.Column<int>(type: "int", nullable: false),
                    TurnirId = table.Column<int>(type: "int", nullable: false),
                    BrojGolovaDomacina = table.Column<int>(type: "int", nullable: false),
                    BrojGolovaGosta = table.Column<int>(type: "int", nullable: false),
                    VrijemeUtakmice = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utakmicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utakmicas_Tims_DomacinId",
                        column: x => x.DomacinId,
                        principalTable: "Tims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Utakmicas_Tims_GostId",
                        column: x => x.GostId,
                        principalTable: "Tims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Utakmicas_Turnirs_TurnirId",
                        column: x => x.TurnirId,
                        principalTable: "Turnirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Utakmicas_DomacinId",
                table: "Utakmicas",
                column: "DomacinId");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmicas_GostId",
                table: "Utakmicas",
                column: "GostId");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmicas_TurnirId",
                table: "Utakmicas",
                column: "TurnirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utakmicas");
        }
    }
}
