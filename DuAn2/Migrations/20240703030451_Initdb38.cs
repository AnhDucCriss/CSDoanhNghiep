using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb38 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dungCus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenDungCu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dungCus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phongHoc_DungCus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhongHocId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungCuId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phongHoc_DungCus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phongHocs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenPhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phongHocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trinhDos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenTrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trinhDos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dungCus");

            migrationBuilder.DropTable(
                name: "phongHoc_DungCus");

            migrationBuilder.DropTable(
                name: "phongHocs");

            migrationBuilder.DropTable(
                name: "trinhDos");
        }
    }
}
