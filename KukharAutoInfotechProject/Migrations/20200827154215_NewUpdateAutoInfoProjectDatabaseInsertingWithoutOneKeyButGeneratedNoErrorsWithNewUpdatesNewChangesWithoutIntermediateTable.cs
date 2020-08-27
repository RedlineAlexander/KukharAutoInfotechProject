using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class NewUpdateAutoInfoProjectDatabaseInsertingWithoutOneKeyButGeneratedNoErrorsWithNewUpdatesNewChangesWithoutIntermediateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Autos_AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Owners_OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutosAndOwners",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "PK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "PK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.AddColumn<int>(
                name: "PKAutoID",
                table: "AutosAndOwners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PKOwnerID",
                table: "AutosAndOwners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutosAndOwners",
                table: "AutosAndOwners",
                columns: new[] { "PKAutoID", "PKOwnerID" });

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_PKOwnerID",
                table: "AutosAndOwners",
                column: "PKOwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Autos_PKAutoID",
                table: "AutosAndOwners",
                column: "PKAutoID",
                principalTable: "Autos",
                principalColumn: "PK_AutoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutosAndOwners_Owners_PKOwnerID",
                table: "AutosAndOwners",
                column: "PKOwnerID",
                principalTable: "Owners",
                principalColumn: "PK_OwnerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Autos_PKAutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Owners_PKOwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutosAndOwners",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_PKOwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "PKAutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "PKOwnerID",
                table: "AutosAndOwners");

            migrationBuilder.AddColumn<int>(
                name: "PK_AutoID",
                table: "AutosAndOwners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PK_OwnerID",
                table: "AutosAndOwners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutosFKPK_AutoID",
                table: "AutosAndOwners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnersFKPK_OwnerID",
                table: "AutosAndOwners",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutosAndOwners",
                table: "AutosAndOwners",
                columns: new[] { "PK_AutoID", "PK_OwnerID" });

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
    }
}
