using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacrament_Planner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Meeting_MeetingsID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MeetingsID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MeetingsID",
                table: "Member");

            migrationBuilder.AddColumn<string>(
                name: "Speaker1Topic",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker2Topic",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker3Topic",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker4Topic",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker5Topic",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker6Topic",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker7Topic",
                table: "Meeting",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speaker1Topic",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker2Topic",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker3Topic",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker4Topic",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker5Topic",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker6Topic",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker7Topic",
                table: "Meeting");

            migrationBuilder.AddColumn<int>(
                name: "MeetingsID",
                table: "Member",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_MeetingsID",
                table: "Member",
                column: "MeetingsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Meeting_MeetingsID",
                table: "Member",
                column: "MeetingsID",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
