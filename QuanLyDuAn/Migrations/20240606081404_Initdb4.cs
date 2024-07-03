using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAn.Migrations
{
    public partial class Initdb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "phongHoc_DungCus",
                columns: table => new
                {
                    PhongHocDungCuId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhongHocId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DungCuId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phongHoc_DungCus", x => x.PhongHocDungCuId);
                    table.ForeignKey(
                        name: "FK_phongHoc_DungCus_dungCus_DungCuId",
                        column: x => x.DungCuId,
                        principalTable: "dungCus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phongHoc_DungCus_phongHocs_PhongHocId",
                        column: x => x.PhongHocId,
                        principalTable: "phongHocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_phongHoc_DungCus_DungCuId",
                table: "phongHoc_DungCus",
                column: "DungCuId");

            migrationBuilder.CreateIndex(
                name: "IX_phongHoc_DungCus_PhongHocId",
                table: "phongHoc_DungCus",
                column: "PhongHocId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "phongHoc_DungCus");
        }
    }
}
