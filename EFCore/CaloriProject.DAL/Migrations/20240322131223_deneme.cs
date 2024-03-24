using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Ogünler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 16, 12, 22, 426, DateTimeKind.Local).AddTicks(5852));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4498));

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

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Yiyecekler",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 22, 14, 37, 26, 864, DateTimeKind.Local).AddTicks(4529));
        }
    }
}
