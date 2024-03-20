using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciOgunYiyecek_Kullanicilar_KullaniciID",
                table: "KullaniciOgunYiyecek");

            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciOgunYiyecek_Ogünler_OgunID",
                table: "KullaniciOgunYiyecek");

            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciOgunYiyecek_Yiyecekler_YiyecekID",
                table: "KullaniciOgunYiyecek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KullaniciOgunYiyecek",
                table: "KullaniciOgunYiyecek");

            migrationBuilder.RenameTable(
                name: "KullaniciOgunYiyecek",
                newName: "KullaniciOgunYiyecekler");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciOgunYiyecek_YiyecekID",
                table: "KullaniciOgunYiyecekler",
                newName: "IX_KullaniciOgunYiyecekler_YiyecekID");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciOgunYiyecek_OgunID",
                table: "KullaniciOgunYiyecekler",
                newName: "IX_KullaniciOgunYiyecekler_OgunID");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciOgunYiyecek_KullaniciID",
                table: "KullaniciOgunYiyecekler",
                newName: "IX_KullaniciOgunYiyecekler_KullaniciID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KullaniciOgunYiyecekler",
                table: "KullaniciOgunYiyecekler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciOgunYiyecekler_Kullanicilar_KullaniciID",
                table: "KullaniciOgunYiyecekler",
                column: "KullaniciID",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciOgunYiyecekler_Ogünler_OgunID",
                table: "KullaniciOgunYiyecekler",
                column: "OgunID",
                principalTable: "Ogünler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciOgunYiyecekler_Yiyecekler_YiyecekID",
                table: "KullaniciOgunYiyecekler",
                column: "YiyecekID",
                principalTable: "Yiyecekler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciOgunYiyecekler_Kullanicilar_KullaniciID",
                table: "KullaniciOgunYiyecekler");

            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciOgunYiyecekler_Ogünler_OgunID",
                table: "KullaniciOgunYiyecekler");

            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciOgunYiyecekler_Yiyecekler_YiyecekID",
                table: "KullaniciOgunYiyecekler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KullaniciOgunYiyecekler",
                table: "KullaniciOgunYiyecekler");

            migrationBuilder.RenameTable(
                name: "KullaniciOgunYiyecekler",
                newName: "KullaniciOgunYiyecek");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciOgunYiyecekler_YiyecekID",
                table: "KullaniciOgunYiyecek",
                newName: "IX_KullaniciOgunYiyecek_YiyecekID");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciOgunYiyecekler_OgunID",
                table: "KullaniciOgunYiyecek",
                newName: "IX_KullaniciOgunYiyecek_OgunID");

            migrationBuilder.RenameIndex(
                name: "IX_KullaniciOgunYiyecekler_KullaniciID",
                table: "KullaniciOgunYiyecek",
                newName: "IX_KullaniciOgunYiyecek_KullaniciID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KullaniciOgunYiyecek",
                table: "KullaniciOgunYiyecek",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciOgunYiyecek_Kullanicilar_KullaniciID",
                table: "KullaniciOgunYiyecek",
                column: "KullaniciID",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciOgunYiyecek_Ogünler_OgunID",
                table: "KullaniciOgunYiyecek",
                column: "OgunID",
                principalTable: "Ogünler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciOgunYiyecek_Yiyecekler_YiyecekID",
                table: "KullaniciOgunYiyecek",
                column: "YiyecekID",
                principalTable: "Yiyecekler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
