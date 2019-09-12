using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class AlterTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoDraws",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoLosses",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoWins",
                table: "Teams",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoDraws",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "NoLosses",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "NoWins",
                table: "Teams");
        }
    }
}
