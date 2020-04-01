using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacrament_Planner.Migrations
{
    public partial class AddSpeakers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hymn_Meeting_MeetingsID",
                table: "Hymn");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Meeting_MeetingsID1",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MeetingsID1",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Hymn_MeetingsID",
                table: "Hymn");

            migrationBuilder.DropColumn(
                name: "MeetingsID1",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MeetingsID",
                table: "Hymn");

            migrationBuilder.AddColumn<string>(
                name: "ClosingHymn",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClosingPrayer",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningHymn",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningPrayer",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SacramentHymn",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker1",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker2",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker3",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker4",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker5",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker6",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker7",
                table: "Meeting",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingHymn",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "ClosingPrayer",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "OpeningHymn",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "OpeningPrayer",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "SacramentHymn",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker1",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker2",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker3",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker4",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker5",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker6",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker7",
                table: "Meeting");

            migrationBuilder.AddColumn<int>(
                name: "MeetingsID1",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeetingsID",
                table: "Hymn",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_MeetingsID1",
                table: "Member",
                column: "MeetingsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Hymn_MeetingsID",
                table: "Hymn",
                column: "MeetingsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hymn_Meeting_MeetingsID",
                table: "Hymn",
                column: "MeetingsID",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Meeting_MeetingsID1",
                table: "Member",
                column: "MeetingsID1",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
