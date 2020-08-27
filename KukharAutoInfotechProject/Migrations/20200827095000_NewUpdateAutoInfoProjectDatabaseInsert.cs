using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class NewUpdateAutoInfoProjectDatabaseInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autos",
                columns: new[] { "PK_AutoID", "AutoColor", "AutoName", "YearFromPipeline" },
                values: new object[] { 1, "Blue", "Mazda", new DateTime(2014, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "PK_OwnerID", "BirthDate", "FatherName", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2000, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovich", "Tyxyi", "Oleksa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 1);
        }
    }
}
