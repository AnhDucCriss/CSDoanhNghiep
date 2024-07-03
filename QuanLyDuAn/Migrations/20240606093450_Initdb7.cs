using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAn.Migrations
{
    public partial class Initdb7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_phongHoc_DungCus_dungCus_DungCuId",
                table: "phongHoc_DungCus");

            migrationBuilder.DropForeignKey(
                name: "FK_phongHoc_DungCus_phongHocs_PhongHocId",
                table: "phongHoc_DungCus");

            migrationBuilder.DropIndex(
                name: "IX_phongHoc_DungCus_DungCuId",
                table: "phongHoc_DungCus");

            migrationBuilder.DropIndex(
                name: "IX_phongHoc_DungCus_PhongHocId",
                table: "phongHoc_DungCus");

            migrationBuilder.RenameColumn(
                name: "PhongHocDungCuId",
                table: "phongHoc_DungCus",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "PhongHocId",
                table: "phongHoc_DungCus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DungCuId",
                table: "phongHoc_DungCus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "phongHoc_DungCus",
                newName: "PhongHocDungCuId");

            migrationBuilder.AlterColumn<string>(
                name: "PhongHocId",
                table: "phongHoc_DungCus",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DungCuId",
                table: "phongHoc_DungCus",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_phongHoc_DungCus_DungCuId",
                table: "phongHoc_DungCus",
                column: "DungCuId");

            migrationBuilder.CreateIndex(
                name: "IX_phongHoc_DungCus_PhongHocId",
                table: "phongHoc_DungCus",
                column: "PhongHocId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_phongHoc_DungCus_dungCus_DungCuId",
                table: "phongHoc_DungCus",
                column: "DungCuId",
                principalTable: "dungCus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_phongHoc_DungCus_phongHocs_PhongHocId",
                table: "phongHoc_DungCus",
                column: "PhongHocId",
                principalTable: "phongHocs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
