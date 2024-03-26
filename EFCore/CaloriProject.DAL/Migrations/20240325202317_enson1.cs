using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class enson1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 23, 16, 578, DateTimeKind.Local).AddTicks(2176));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 23, 22, 30, 200, DateTimeKind.Local).AddTicks(759));
        }
    }
}
