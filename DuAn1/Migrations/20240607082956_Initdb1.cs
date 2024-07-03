﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn1.Migrations
{
    public partial class Initdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "giaoViens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "giaoViens");
        }
    }
}
