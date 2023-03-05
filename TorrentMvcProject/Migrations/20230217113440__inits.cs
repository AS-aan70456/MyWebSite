using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrentMvcProject.Migrations
{
    public partial class _inits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_GameItems_GameItemid",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_GameItemid",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "GameItemid",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "teg",
                table: "GameItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "teg",
                table: "GameItems");

            migrationBuilder.AddColumn<int>(
                name: "GameItemid",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GameItemid",
                table: "Categories",
                column: "GameItemid");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_GameItems_GameItemid",
                table: "Categories",
                column: "GameItemid",
                principalTable: "GameItems",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
