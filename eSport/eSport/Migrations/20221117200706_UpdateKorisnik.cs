using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class UpdateKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bodovi",
                table: "Korisniks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bodovi",
                table: "Korisniks");
        }
    }
}
