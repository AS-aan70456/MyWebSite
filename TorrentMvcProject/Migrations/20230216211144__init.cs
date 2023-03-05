using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrentMvcProject.Migrations
{
    public partial class _init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    like = table.Column<int>(type: "int", nullable: false),
                    dizlike = table.Column<int>(type: "int", nullable: false),
                    mainImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    languages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Windows = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    videoCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameItems", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameItemid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categories_GameItems_GameItemid",
                        column: x => x.GameItemid,
                        principalTable: "GameItems",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GameItemid",
                table: "Categories",
                column: "GameItemid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "GameItems");
        }
    }
}
