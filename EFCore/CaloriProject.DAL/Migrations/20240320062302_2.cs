using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YiyecekID",
                table: "Yiyecekler");

            migrationBuilder.DropColumn(
                name: "OgunID",
                table: "Ogünler");

            migrationBuilder.DropColumn(
                name: "KullaniciID",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Kategoriler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YiyecekID",
                table: "Yiyecekler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OgunID",
                table: "Ogünler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciID",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "Kategoriler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
