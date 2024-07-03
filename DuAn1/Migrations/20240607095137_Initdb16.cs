using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn1.Migrations
{
    public partial class Initdb16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "mucTienCongs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "GiaoVienId",
                table: "mucTienCongs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GiaoVienId",
                table: "lichDays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GiaoVienId",
                table: "mucTienCongs");

            migrationBuilder.DropColumn(
                name: "GiaoVienId",
                table: "lichDays");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "mucTienCongs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
