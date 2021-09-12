using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Services.Migrations
{
    public partial class xfdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_News_NewsId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_NewsId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Tags");

            migrationBuilder.CreateTable(
                name: "newsToTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsToTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_newsToTags_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_newsToTags_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_newsToTags_NewsId",
                table: "newsToTags",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_newsToTags_TagsId",
                table: "newsToTags",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newsToTags");

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_NewsId",
                table: "Tags",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_News_NewsId",
                table: "Tags",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
