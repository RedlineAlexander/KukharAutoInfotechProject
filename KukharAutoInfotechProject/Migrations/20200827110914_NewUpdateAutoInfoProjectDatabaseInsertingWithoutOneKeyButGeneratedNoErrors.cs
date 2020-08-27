using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class NewUpdateAutoInfoProjectDatabaseInsertingWithoutOneKeyButGeneratedNoErrors : Migration
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

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AutosFKPK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropColumn(
                name: "OwnersFKPK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutosAndOwners",
                table: "AutosAndOwners",
                columns: new[] { "PK_AutoID", "PK_OwnerID" });

            migrationBuilder.InsertData(
                table: "Autos",
                columns: new[] { "PK_AutoID", "AutoColor", "AutoName", "YearFromPipeline" },
                values: new object[] { 3, "Red", "Mazda", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "PK_OwnerID", "BirthDate", "FatherName", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Tyxy", "Oleks" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Autos_PK_AutoID",
                table: "AutosAndOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_AutosAndOwners_Owners_PK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutosAndOwners",
                table: "AutosAndOwners");

            migrationBuilder.DropIndex(
                name: "IX_AutosAndOwners_PK_OwnerID",
                table: "AutosAndOwners");

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 3);

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
                column: "AutosAndOwnersID");

            migrationBuilder.InsertData(
                table: "Autos",
                columns: new[] { "PK_AutoID", "AutoColor", "AutoName", "YearFromPipeline" },
                values: new object[] { 2, "Red", "Mazda", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "PK_OwnerID", "BirthDate", "FatherName", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Tyxy", "Oleks" });

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
