using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn1.Migrations
{
    public partial class Initdb15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lichDays",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    thu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioBatDau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioKetThuc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mucTienCongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaiTrungTam30p = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaiNha30p = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaiTrungTam45p = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaiNha45p = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaiTrungTam60p = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaiNha60p = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mucTienCongs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lichDays");

            migrationBuilder.DropTable(
                name: "mucTienCongs");
        }
    }
}
