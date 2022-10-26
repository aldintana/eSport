using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class UpdateTurnir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGenerisan",
                table: "Turnirs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGenerisan",
                table: "Turnirs");
        }
    }
}
