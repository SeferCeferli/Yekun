using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Services.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerPhone",
                table: "Advertisment");

            migrationBuilder.DropColumn(
                name: "PressPhone",
                table: "Advertisment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerPhone",
                table: "Advertisment",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PressPhone",
                table: "Advertisment",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
