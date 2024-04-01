using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogünler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogünler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yiyecekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YiyecekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Porsiyon = table.Column<double>(type: "float", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yiyecekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yiyecekler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciOgunYiyecekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Porsiyon = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciOgunYiyecekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciOgunYiyecekler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciOgunYiyecekler_Ogünler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogünler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciOgunYiyecekler_Yiyecekler_YiyecekID",
                        column: x => x.YiyecekID,
                        principalTable: "Yiyecekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "KategoriAdi", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1654), null, "Kahvalti", 1, null },
                    { 2, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1655), null, "Ara Sicak", 1, null },
                    { 3, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1656), null, "Aperatifler", 1, null },
                    { 4, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1657), null, "Corbalar", 1, null },
                    { 5, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1658), null, "Ana Yemekler", 1, null },
                    { 6, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1659), null, "Icecekler", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Ogünler",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OgunAdi", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1541), null, "Kahvalti", 1, null },
                    { 2, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1551), null, "Ogle", 1, null },
                    { 3, new DateTime(2024, 3, 22, 14, 17, 30, 613, DateTimeKind.Local).AddTicks(1552), null, "Aksam", 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgunYiyecekler_KullaniciID",
                table: "KullaniciOgunYiyecekler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgunYiyecekler_OgunID",
                table: "KullaniciOgunYiyecekler",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgunYiyecekler_YiyecekID",
                table: "KullaniciOgunYiyecekler",
                column: "YiyecekID");

            migrationBuilder.CreateIndex(
                name: "IX_Yiyecekler_KategoriID",
                table: "Yiyecekler",
                column: "KategoriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciOgunYiyecekler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Ogünler");

            migrationBuilder.DropTable(
                name: "Yiyecekler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
