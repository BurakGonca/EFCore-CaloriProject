using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 22, 8, 58, 467, DateTimeKind.Local).AddTicks(2852));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
