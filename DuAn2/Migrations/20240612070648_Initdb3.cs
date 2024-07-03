using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hocViens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    maHocVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenHocVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    soDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soDTCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ghiChuCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soDTMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ghiChuMe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hocViens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hocViens");
        }
    }
}
