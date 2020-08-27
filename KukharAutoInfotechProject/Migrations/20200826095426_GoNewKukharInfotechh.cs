using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class GoNewKukharInfotechh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutosAndOwnersID",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutosAndOwners",
                table: "Autos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutosAndOwnersID",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "AutosAndOwners",
                table: "Autos");
        }
    }
}
