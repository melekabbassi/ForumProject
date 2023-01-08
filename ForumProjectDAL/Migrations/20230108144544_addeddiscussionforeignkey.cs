using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumProjectDAL.Migrations
{
    public partial class addeddiscussionforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Discussions_ThemeId",
                table: "Discussions",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Themes_ThemeId",
                table: "Discussions",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "ThemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Themes_ThemeId",
                table: "Discussions");

            migrationBuilder.DropIndex(
                name: "IX_Discussions_ThemeId",
                table: "Discussions");
        }
    }
}
