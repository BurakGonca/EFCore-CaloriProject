using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "KategoriAdi", "Status", "UpdatedDate" },
                values: new object[] { 7, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4498), null, "Tatli", 1, null });

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.InsertData(
                table: "Yiyecekler",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Fotograf", "Kalori", "KategoriID", "Porsiyon", "Status", "UpdatedDate", "YiyecekAdi" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4518), null, null, 300.0, 5, 1.0, 1, null, "Manti" },
                    { 2, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4520), null, null, 200.0, 1, 1.0, 1, null, "Menemen" },
                    { 3, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4521), null, null, 300.0, 3, 2.0, 1, null, "Patates Kızartmasi" },
                    { 4, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4522), null, null, 500.0, 5, 1.0, 1, null, "Adana Kebap" },
                    { 5, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4524), null, null, 200.0, 4, 1.0, 1, null, "Mercimek Corbasi" },
                    { 7, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4526), null, null, 50.0, 6, 1.0, 1, null, "Su" },
                    { 8, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4527), null, null, 200.0, 1, 1.0, 1, null, "Omlet" },
                    { 9, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4528), null, null, 400.0, 2, 1.0, 1, null, "Yaprak Ciger" },
                    { 6, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4525), null, null, 400.0, 7, 1.0, 1, null, "Baklava" },
                    { 10, new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4529), null, null, 200.0, 7, 1.0, 1, null, "Sütlü Nuriye" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1552));
        }
    }
}
