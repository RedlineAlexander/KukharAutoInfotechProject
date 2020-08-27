using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KukharAutoInfotechProject.Migrations
{
    public partial class NewUpdateAutoInfoProjectDatabaseInsertingWithoutOneKeyButGeneratedNoErrorsWithNewUpdatesNewChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 3,
                column: "AutoName",
                value: "Dodge");

            migrationBuilder.InsertData(
                table: "Autos",
                columns: new[] { "PK_AutoID", "AutoColor", "AutoName", "YearFromPipeline" },
                values: new object[,]
                {
                    { 10, "Red", "Opel", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Red", "Mitsubishi", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Red", "Mercedes", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Red", "Maybach", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "Red", "Mazda", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Red", "Vuxhall", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Red", "Renault", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Blue", "Mazda", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Red", "Bentley", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2000, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Milosh", "Milog" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "PK_OwnerID", "BirthDate", "FatherName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Myroslav", "Mstisyavskiy" },
                    { 4, new DateTime(2004, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksioviivna", "Tayanna", "Oblakevich" },
                    { 5, new DateTime(2003, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Boghdan", "Oleksashenko" },
                    { 6, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Miron", "Soblevskyi" },
                    { 7, new DateTime(2000, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Teheran", "Oleksash" },
                    { 8, new DateTime(2001, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Ahmed", "Oleks" },
                    { 9, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Vyacheslavivna", "Tasha", "Olegarieva" },
                    { 10, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Sergiy", "Oleks" },
                    { 1, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Tyxy", "Oleks" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Autos",
                keyColumn: "PK_AutoID",
                keyValue: 3,
                column: "AutoName",
                value: "Mazda");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "PK_OwnerID",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Tyxy", "Oleks" });
        }
    }
}
