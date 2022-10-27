using Microsoft.EntityFrameworkCore.Migrations;

namespace eSport.Migrations
{
    public partial class UpdateUtakmica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsZavrsena",
                table: "Utakmicas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsZavrsena",
                table: "Utakmicas");
        }
    }
}
