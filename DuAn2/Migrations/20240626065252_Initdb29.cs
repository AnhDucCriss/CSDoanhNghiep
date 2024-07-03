using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdGiaoVien",
                table: "TKBs");

            migrationBuilder.DropColumn(
                name: "IdLop",
                table: "TKBs");

            migrationBuilder.DropColumn(
                name: "IdPhongHoc",
                table: "TKBs");

            migrationBuilder.RenameColumn(
                name: "IdMonHoc",
                table: "TKBs",
                newName: "TietHoc");

            migrationBuilder.RenameColumn(
                name: "MonHocId",
                table: "lopHocs",
                newName: "IdPhongHoc");

            migrationBuilder.RenameColumn(
                name: "GiaoVienId",
                table: "lopHocs",
                newName: "IdMonHoc");

            migrationBuilder.RenameColumn(
                name: "DiaDiem",
                table: "lopHocs",
                newName: "IdGiaoVien");

            migrationBuilder.AddColumn<DateTime>(
                name: "GioBatDau",
                table: "TKBs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GioKetThuc",
                table: "TKBs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Thu",
                table: "TKBs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GioBatDau",
                table: "TKBs");

            migrationBuilder.DropColumn(
                name: "GioKetThuc",
                table: "TKBs");

            migrationBuilder.DropColumn(
                name: "Thu",
                table: "TKBs");

            migrationBuilder.RenameColumn(
                name: "TietHoc",
                table: "TKBs",
                newName: "IdMonHoc");

            migrationBuilder.RenameColumn(
                name: "IdPhongHoc",
                table: "lopHocs",
                newName: "MonHocId");

            migrationBuilder.RenameColumn(
                name: "IdMonHoc",
                table: "lopHocs",
                newName: "GiaoVienId");

            migrationBuilder.RenameColumn(
                name: "IdGiaoVien",
                table: "lopHocs",
                newName: "DiaDiem");

            migrationBuilder.AddColumn<string>(
                name: "IdGiaoVien",
                table: "TKBs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdLop",
                table: "TKBs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdPhongHoc",
                table: "TKBs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
