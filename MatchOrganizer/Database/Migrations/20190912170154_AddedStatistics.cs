using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class AddedStatistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_GuestTeamId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_HostTeamId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Status_StatusId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Team_TeamId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Matches");

            migrationBuilder.RenameIndex(
                name: "IX_Team_Name",
                table: "Teams",
                newName: "IX_Teams_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Match_StatusId",
                table: "Matches",
                newName: "IX_Matches_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_HostTeamId",
                table: "Matches",
                newName: "IX_Matches_HostTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_GuestTeamId",
                table: "Matches",
                newName: "IX_Matches_GuestTeamId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Statuses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matches",
                table: "Matches",
                column: "MatchId");

            migrationBuilder.CreateTable(
                name: "PlayerStatistics",
                columns: table => new
                {
                    PlayerStatisticsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoMatches = table.Column<int>(nullable: false),
                    NoGoals = table.Column<int>(nullable: false),
                    NotActive = table.Column<bool>(nullable: false, defaultValue: false),
                    PlayerId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatistics", x => x.PlayerStatisticsId);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_PlayerId",
                table: "PlayerStatistics",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_TeamId",
                table: "PlayerStatistics",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_GuestTeamId",
                table: "Matches",
                column: "GuestTeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_HostTeamId",
                table: "Matches",
                column: "HostTeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Statuses_StatusId",
                table: "Matches",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_GuestTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_HostTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Statuses_StatusId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "PlayerStatistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matches",
                table: "Matches");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Status");

            migrationBuilder.RenameTable(
                name: "Matches",
                newName: "Match");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_Name",
                table: "Team",
                newName: "IX_Team_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_StatusId",
                table: "Match",
                newName: "IX_Match_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_HostTeamId",
                table: "Match",
                newName: "IX_Match_HostTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_GuestTeamId",
                table: "Match",
                newName: "IX_Match_GuestTeamId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Status",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_GuestTeamId",
                table: "Match",
                column: "GuestTeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_HostTeamId",
                table: "Match",
                column: "HostTeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Status_StatusId",
                table: "Match",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Team_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
