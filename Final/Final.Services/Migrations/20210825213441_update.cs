using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Services.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "News",
                newName: "Description3");

            migrationBuilder.AlterColumn<string>(
                name: "MainImage",
                table: "News",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "News",
                type: "ntext",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "News",
                type: "ntext",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "News",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "News",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "News",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoImage",
                table: "News",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "News");

            migrationBuilder.DropColumn(
                name: "VideoImage",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "Description3",
                table: "News",
                newName: "Text");

            migrationBuilder.AlterColumn<string>(
                name: "MainImage",
                table: "News",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);
        }
    }
}
