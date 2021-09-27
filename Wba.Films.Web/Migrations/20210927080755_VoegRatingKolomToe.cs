using Microsoft.EntityFrameworkCore.Migrations;

namespace Wba.Films.Web.Migrations
{
    public partial class VoegRatingKolomToe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Film",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Film");
        }
    }
}
