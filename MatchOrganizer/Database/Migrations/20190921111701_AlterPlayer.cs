using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class AlterPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Players",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FullName",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
