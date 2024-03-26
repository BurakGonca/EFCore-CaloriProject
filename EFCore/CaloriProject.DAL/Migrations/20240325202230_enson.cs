using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class enson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgunAdi",
                table: "Ogünler",
                newName: "OgunAd");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(720), 0 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(721), 0 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(722), 0 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(723), 0 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(724), 0 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(724), 0 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(725), 0 });

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(583), 0 });

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(593), 0 });

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(594), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(749), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(751), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(752), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(753), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(754), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(755), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(756), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(757), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(758), 0 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(759), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgunAd",
                table: "Ogünler",
                newName: "OgunAdi");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8777), 1 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8778), 1 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8779), 1 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8779), 1 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8780), 1 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8780), 1 });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8781), 1 });

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8699), 1 });

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8703), 1 });

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8703), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8795), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8797), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8797), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8798), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8799), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8800), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8800), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8801), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8802), 1 });

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 58, 28, 91, DateTimeKind.Local).AddTicks(8802), 1 });
        }
    }
}
