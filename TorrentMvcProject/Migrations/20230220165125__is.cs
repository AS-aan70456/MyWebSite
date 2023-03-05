using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrentMvcProject.Migrations
{
    public partial class _is : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "puthToTorrent",
                table: "GameItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "puthToTorrent",
                table: "GameItems");
        }
    }
}
