using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class GoNewKukharInfotech : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Autos_AutosAutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Owners_OwnersOwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_AutosAutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_OwnersOwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autos",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "AutosAutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "OwnersOwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "AutoID",
                table: "Autos");

            migrationBuilder.AddColumn<int>(
                name: "PK_OwnerID",
                table: "Owners",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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
                table: "Autos",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "PK_OwnerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autos",
                table: "Autos",
                column: "PK_AutoID");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autos",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "PK_OwnerID",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "PK_AutoID",
                table: "Autos");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AutoID",
                table: "AutosAndOwners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutosAutoID",
                table: "AutosAndOwners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "AutosAndOwners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnersOwnerID",
                table: "AutosAndOwners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutoID",
                table: "Autos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "OwnerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autos",
                table: "Autos",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_AutosAutoID",
                table: "AutosAndOwners",
                column: "AutosAutoID");

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_OwnersOwnerID",
                table: "AutosAndOwners",
                column: "OwnersOwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Autos_AutosAutoID",
                table: "AutosAndOwners",
                column: "AutosAutoID",
                principalTable: "Autos",
                principalColumn: "AutoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Owners_OwnersOwnerID",
                table: "AutosAndOwners",
                column: "OwnersOwnerID",
                principalTable: "Owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
