using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdLopHoc",
                table: "TKBs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdLopHoc",
                table: "TKBs");
        }
    }
}
