using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAn.Migrations
{
    public partial class Initdb10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "giaoViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenGiaoVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cccd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrinhDoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_giaoViens_trinhDos_TrinhDoId",
                        column: x => x.TrinhDoId,
                        principalTable: "trinhDos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_giaoViens_TrinhDoId",
                table: "giaoViens",
                column: "TrinhDoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "giaoViens");
        }
    }
}
