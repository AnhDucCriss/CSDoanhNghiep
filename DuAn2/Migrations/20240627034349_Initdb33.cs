using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThoiDiemId",
                table: "lichTKBs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "thoiDiems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    value = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thoiDiems", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lichTKBs_ThoiDiemId",
                table: "lichTKBs",
                column: "ThoiDiemId");

            migrationBuilder.AddForeignKey(
                name: "FK_lichTKBs_thoiDiems_ThoiDiemId",
                table: "lichTKBs",
                column: "ThoiDiemId",
                principalTable: "thoiDiems",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lichTKBs_thoiDiems_ThoiDiemId",
                table: "lichTKBs");

            migrationBuilder.DropTable(
                name: "thoiDiems");

            migrationBuilder.DropIndex(
                name: "IX_lichTKBs_ThoiDiemId",
                table: "lichTKBs");

            migrationBuilder.DropColumn(
                name: "ThoiDiemId",
                table: "lichTKBs");
        }
    }
}
