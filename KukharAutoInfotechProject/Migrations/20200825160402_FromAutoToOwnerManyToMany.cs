using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class FromAutoToOwnerManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoName = table.Column<string>(nullable: true),
                    AutoColor = table.Column<string>(nullable: true),
                    YearFromPipeline = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.AutoID);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerID);
                });

            migrationBuilder.CreateTable(
                name: "AutosAndOwners",
                columns: table => new
                {
                    AutosAndOwnersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoID = table.Column<int>(nullable: false),
                    OwnerID = table.Column<int>(nullable: false),
                    AutosAutoID = table.Column<int>(nullable: true),
                    OwnersOwnerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutosAndOwners", x => x.AutosAndOwnersID);
                    table.ForeignKey(
                        name: "FK_AutosAndOwners_Autos_AutosAutoID",
                        column: x => x.AutosAutoID,
                        principalTable: "Autos",
                        principalColumn: "AutoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutosAndOwners_Owners_OwnersOwnerID",
                        column: x => x.OwnersOwnerID,
                        principalTable: "Owners",
                        principalColumn: "OwnerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_AutosAutoID",
                table: "AutosAndOwners",
                column: "AutosAutoID");

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_OwnersOwnerID",
                table: "AutosAndOwners",
                column: "OwnersOwnerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutosAndOwners");

            migrationBuilder.DropTable(
                name: "Autos");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
