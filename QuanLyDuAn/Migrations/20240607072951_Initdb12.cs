using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDuAn.Migrations
{
    public partial class Initdb12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_giaoViens_trinhDos_TrinhDoId",
                table: "giaoViens");

            migrationBuilder.DropIndex(
                name: "IX_giaoViens_TrinhDoId",
                table: "giaoViens");

            migrationBuilder.AlterColumn<string>(
                name: "TrinhDoId",
                table: "giaoViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TrinhDoId",
                table: "giaoViens",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_giaoViens_TrinhDoId",
                table: "giaoViens",
                column: "TrinhDoId");

            migrationBuilder.AddForeignKey(
                name: "FK_giaoViens_trinhDos_TrinhDoId",
                table: "giaoViens",
                column: "TrinhDoId",
                principalTable: "trinhDos",
                principalColumn: "Id");
        }
    }
}
