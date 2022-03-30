using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioMVC.Migrations
{
    public partial class CriaStatusEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Eventos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Eventos");
        }
    }
}
