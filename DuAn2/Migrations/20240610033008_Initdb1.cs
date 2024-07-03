using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "giaoViens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tenGiaoVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cccd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soDienThoai = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soTaiKhoan = table.Column<int>(type: "int", nullable: false),
                    nganHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maThue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giaoViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lichDays",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    thu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioBatDau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioKetThuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaoVienId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mucTienCongs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiaoVienId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonHocId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaiTrungTam30p = table.Column<double>(type: "float", nullable: true),
                    TaiNha30p = table.Column<double>(type: "float", nullable: true),
                    TaiTrungTam45p = table.Column<double>(type: "float", nullable: true),
                    TaiNha45p = table.Column<double>(type: "float", nullable: true),
                    TaiTrungTam60p = table.Column<double>(type: "float", nullable: true),
                    TaiNha60p = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mucTienCongs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "giaoViens");

            migrationBuilder.DropTable(
                name: "lichDays");

            migrationBuilder.DropTable(
                name: "mucTienCongs");
        }
    }
}
