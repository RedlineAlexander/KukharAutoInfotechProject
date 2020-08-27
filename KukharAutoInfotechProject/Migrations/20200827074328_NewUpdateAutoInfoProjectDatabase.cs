using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class NewUpdateAutoInfoProjectDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Autos_AutosID",
                table: "AutosAndOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Owners_OwnersID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_AutosID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_OwnersID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "AutosAndOwnersID",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "AutosID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "OwnersID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "AutosAndOwners",
                table: "Autos");

            migrationBuilder.AddColumn<int>(
                name: "AutosFKPK_AutoID",
                table: "AutosAndOwners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnersFKPK_OwnerID",
                table: "AutosAndOwners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PK_AutoID",
                table: "AutosAndOwners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PK_OwnerID",
                table: "AutosAndOwners",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "PK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "PK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.AddColumn<int>(
                name: "AutosAndOwnersID",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutosID",
                table: "AutosAndOwners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnersID",
                table: "AutosAndOwners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutosAndOwners",
                table: "Autos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_AutosID",
                table: "AutosAndOwners",
                column: "AutosID");

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_OwnersID",
                table: "AutosAndOwners",
                column: "OwnersID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Autos_AutosID",
                table: "AutosAndOwners",
                column: "AutosID",
                principalTable: "Autos",
                principalColumn: "PK_AutoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Owners_OwnersID",
                table: "AutosAndOwners",
                column: "OwnersID",
                principalTable: "Owners",
                principalColumn: "PK_OwnerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
