using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class NewUpdateAutoInfoProjectDatabaseInsertingWithoutOneKeyButGeneratedNoErrorsWithNewUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Autos_PK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Owners_PK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_PK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "AutosAndOwnersID",
                table: "AutosAndOwners");

            migrationBuilder.AddColumn<int>(
                name: "AutosFKPK_AutoID",
                table: "AutosAndOwners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnersFKPK_OwnerID",
                table: "AutosAndOwners",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_AutosFKPK_AutoID",
                table: "AutosAndOwners",
                column: "AutosFKPK_AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_OwnersFKPK_OwnerID",
                table: "AutosAndOwners",
                column: "OwnersFKPK_OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Autos_AutosFKPK_AutoID",
                table: "AutosAndOwners",
                column: "AutosFKPK_AutoID",
                principalTable: "Autos",
                principalColumn: "PK_AutoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Owners_OwnersFKPK_OwnerID",
                table: "AutosAndOwners",
                column: "OwnersFKPK_OwnerID",
                principalTable: "Owners",
                principalColumn: "PK_OwnerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Autos_AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Owners_OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.AddColumn<int>(
                name: "AutosAndOwnersID",
                table: "AutosAndOwners",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_PK_OwnerID",
                table: "AutosAndOwners",
                column: "PK_OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Autos_PK_AutoID",
                table: "AutosAndOwners",
                column: "PK_AutoID",
                principalTable: "Autos",
                principalColumn: "PK_AutoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Owners_PK_OwnerID",
                table: "AutosAndOwners",
                column: "PK_OwnerID",
                principalTable: "Owners",
                principalColumn: "PK_OwnerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
