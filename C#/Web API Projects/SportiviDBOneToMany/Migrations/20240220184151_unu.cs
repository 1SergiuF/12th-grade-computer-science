using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportiviDBOneToMany.Migrations
{
    /// <inheritdoc />
    public partial class unu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sporturi",
                columns: table => new
                {
                    SportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportNume = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sporturi", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "sportiv",
                columns: table => new
                {
                    SportivID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sportiv", x => x.SportivID);
                    table.ForeignKey(
                        name: "FK_sportiv_sporturi_SportId",
                        column: x => x.SportId,
                        principalTable: "sporturi",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sportiv_SportId",
                table: "sportiv",
                column: "SportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sportiv");

            migrationBuilder.DropTable(
                name: "sporturi");
        }
    }
}
