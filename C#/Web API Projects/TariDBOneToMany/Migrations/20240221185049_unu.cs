using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TariDBOneToMany.Migrations
{
    /// <inheritdoc />
    public partial class unu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tari",
                columns: table => new
                {
                    TaraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaraNume = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tari", x => x.TaraID);
                });

            migrationBuilder.CreateTable(
                name: "locuitori",
                columns: table => new
                {
                    LocuitorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeLocuitor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VarstaLocuitor = table.Column<int>(type: "int", nullable: true),
                    TaraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locuitori", x => x.LocuitorID);
                    table.ForeignKey(
                        name: "FK_locuitori_tari_TaraId",
                        column: x => x.TaraId,
                        principalTable: "tari",
                        principalColumn: "TaraID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_locuitori_TaraId",
                table: "locuitori",
                column: "TaraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "locuitori");

            migrationBuilder.DropTable(
                name: "tari");
        }
    }
}
