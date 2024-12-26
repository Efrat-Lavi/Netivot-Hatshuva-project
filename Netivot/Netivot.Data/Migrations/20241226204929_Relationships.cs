using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netivot.Data.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvrechId",
                table: "meetings");

            migrationBuilder.AddColumn<int>(
                name: "AvrechId",
                table: "mitchazkim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DonorId",
                table: "donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_mitchazkim_AvrechId",
                table: "mitchazkim",
                column: "AvrechId");

            migrationBuilder.CreateIndex(
                name: "IX_meetings_MitchazekId",
                table: "meetings",
                column: "MitchazekId");

            migrationBuilder.CreateIndex(
                name: "IX_donations_DonorId",
                table: "donations",
                column: "DonorId");

            migrationBuilder.AddForeignKey(
                name: "FK_donations_donors_DonorId",
                table: "donations",
                column: "DonorId",
                principalTable: "donors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_meetings_mitchazkim_MitchazekId",
                table: "meetings",
                column: "MitchazekId",
                principalTable: "mitchazkim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mitchazkim_avrechim_AvrechId",
                table: "mitchazkim",
                column: "AvrechId",
                principalTable: "avrechim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_donations_donors_DonorId",
                table: "donations");

            migrationBuilder.DropForeignKey(
                name: "FK_meetings_mitchazkim_MitchazekId",
                table: "meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_mitchazkim_avrechim_AvrechId",
                table: "mitchazkim");

            migrationBuilder.DropIndex(
                name: "IX_mitchazkim_AvrechId",
                table: "mitchazkim");

            migrationBuilder.DropIndex(
                name: "IX_meetings_MitchazekId",
                table: "meetings");

            migrationBuilder.DropIndex(
                name: "IX_donations_DonorId",
                table: "donations");

            migrationBuilder.DropColumn(
                name: "AvrechId",
                table: "mitchazkim");

            migrationBuilder.DropColumn(
                name: "DonorId",
                table: "donations");

            migrationBuilder.AddColumn<int>(
                name: "AvrechId",
                table: "meetings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
