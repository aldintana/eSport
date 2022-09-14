using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class TerminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Termins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pocetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kraj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Termins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Termins_Cjenovniks_CjenovnikId",
                        column: x => x.CjenovnikId,
                        principalTable: "Cjenovniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Termins_Korisniks_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Termins_Terens_TerenId",
                        column: x => x.TerenId,
                        principalTable: "Terens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Termins_CjenovnikId",
                table: "Termins",
                column: "CjenovnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Termins_KorisnikId",
                table: "Termins",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Termins_TerenId",
                table: "Termins",
                column: "TerenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Termins");
        }
    }
}
