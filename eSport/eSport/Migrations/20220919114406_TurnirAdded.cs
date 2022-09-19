using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class TurnirAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turnirs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumKraja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VrijemePocetka = table.Column<int>(type: "int", nullable: false),
                    VrijemeKraja = table.Column<int>(type: "int", nullable: false),
                    TerenId = table.Column<int>(type: "int", nullable: false),
                    CjenovnikId = table.Column<int>(type: "int", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: true),
                    IsPotvrdjen = table.Column<bool>(type: "bit", nullable: false),
                    UkupnaCijena = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnirs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turnirs_Cjenovniks_CjenovnikId",
                        column: x => x.CjenovnikId,
                        principalTable: "Cjenovniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Turnirs_Korisniks_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Turnirs_Terens_TerenId",
                        column: x => x.TerenId,
                        principalTable: "Terens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turnirs_CjenovnikId",
                table: "Turnirs",
                column: "CjenovnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnirs_KorisnikId",
                table: "Turnirs",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnirs_TerenId",
                table: "Turnirs",
                column: "TerenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turnirs");
        }
    }
}
