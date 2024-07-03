using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class initdb23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdHocVien",
                table: "lopHocViens");

            migrationBuilder.RenameColumn(
                name: "maLopHoc",
                table: "lichHocs",
                newName: "IdLopHoc");

            migrationBuilder.RenameColumn(
                name: "maLopHoc",
                table: "hocViens",
                newName: "IdLopHoc");

            migrationBuilder.AddColumn<string>(
                name: "HocVienId",
                table: "lopHocViens",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_lopHocViens_HocVienId",
                table: "lopHocViens",
                column: "HocVienId");

            migrationBuilder.AddForeignKey(
                name: "FK_lopHocViens_hocViens_HocVienId",
                table: "lopHocViens",
                column: "HocVienId",
                principalTable: "hocViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lopHocViens_hocViens_HocVienId",
                table: "lopHocViens");

            migrationBuilder.DropIndex(
                name: "IX_lopHocViens_HocVienId",
                table: "lopHocViens");

            migrationBuilder.DropColumn(
                name: "HocVienId",
                table: "lopHocViens");

            migrationBuilder.RenameColumn(
                name: "IdLopHoc",
                table: "lichHocs",
                newName: "maLopHoc");

            migrationBuilder.RenameColumn(
                name: "IdLopHoc",
                table: "hocViens",
                newName: "maLopHoc");

            migrationBuilder.AddColumn<string>(
                name: "IdHocVien",
                table: "lopHocViens",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);
        }
    }
}
