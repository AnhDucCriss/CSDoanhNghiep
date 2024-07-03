using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAn.Migrations
{
    public partial class Initdb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_phongHoc_DungCus_PhongHocId",
                table: "phongHoc_DungCus");

            migrationBuilder.CreateIndex(
                name: "IX_phongHoc_DungCus_PhongHocId",
                table: "phongHoc_DungCus",
                column: "PhongHocId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_phongHoc_DungCus_PhongHocId",
                table: "phongHoc_DungCus");

            migrationBuilder.CreateIndex(
                name: "IX_phongHoc_DungCus_PhongHocId",
                table: "phongHoc_DungCus",
                column: "PhongHocId");
        }
    }
}
