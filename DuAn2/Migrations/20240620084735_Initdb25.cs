using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TKBs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IdLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdGiaoVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TKBs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TKBs");
        }
    }
}
