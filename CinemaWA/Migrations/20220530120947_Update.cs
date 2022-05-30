using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaWA.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sessaoinfo",
                table: "Sessao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssentoInfo",
                table: "Assento",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sessaoinfo",
                table: "Sessao");

            migrationBuilder.DropColumn(
                name: "AssentoInfo",
                table: "Assento");
        }
    }
}
