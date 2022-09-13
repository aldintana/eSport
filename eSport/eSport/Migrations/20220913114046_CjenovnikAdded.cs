using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class CjenovnikAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cjenovniks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cijena = table.Column<int>(type: "int", nullable: false),
                    TipRezervacijeId = table.Column<int>(type: "int", nullable: false),
                    TerenId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cjenovniks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cjenovniks_Terens_TerenId",
                        column: x => x.TerenId,
                        principalTable: "Terens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cjenovniks_TipRezervacijes_TipRezervacijeId",
                        column: x => x.TipRezervacijeId,
                        principalTable: "TipRezervacijes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovniks_TerenId",
                table: "Cjenovniks",
                column: "TerenId");

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovniks_TipRezervacijeId",
                table: "Cjenovniks",
                column: "TipRezervacijeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cjenovniks");
        }
    }
}
