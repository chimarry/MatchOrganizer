using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class AlterStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NotActive",
                table: "Statuses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotActive",
                table: "Statuses");
        }
    }
}
