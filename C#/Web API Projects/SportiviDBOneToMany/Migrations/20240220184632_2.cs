using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportiviDBOneToMany.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sportiv_sporturi_SportId",
                table: "sportiv");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sportiv",
                table: "sportiv");

            migrationBuilder.RenameTable(
                name: "sportiv",
                newName: "sportivi");

            migrationBuilder.RenameIndex(
                name: "IX_sportiv_SportId",
                table: "sportivi",
                newName: "IX_sportivi_SportId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sportivi",
                table: "sportivi",
                column: "SportivID");

            migrationBuilder.AddForeignKey(
                name: "FK_sportivi_sporturi_SportId",
                table: "sportivi",
                column: "SportId",
                principalTable: "sporturi",
                principalColumn: "SportID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sportivi_sporturi_SportId",
                table: "sportivi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sportivi",
                table: "sportivi");

            migrationBuilder.RenameTable(
                name: "sportivi",
                newName: "sportiv");

            migrationBuilder.RenameIndex(
                name: "IX_sportivi_SportId",
                table: "sportiv",
                newName: "IX_sportiv_SportId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sportiv",
                table: "sportiv",
                column: "SportivID");

            migrationBuilder.AddForeignKey(
                name: "FK_sportiv_sporturi_SportId",
                table: "sportiv",
                column: "SportId",
                principalTable: "sporturi",
                principalColumn: "SportID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
