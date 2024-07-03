using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class initdb13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KhungGioId",
                table: "timeSlots",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_timeSlots_KhungGioId",
                table: "timeSlots",
                column: "KhungGioId");

            migrationBuilder.AddForeignKey(
                name: "FK_timeSlots_khungGios_KhungGioId",
                table: "timeSlots",
                column: "KhungGioId",
                principalTable: "khungGios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_timeSlots_khungGios_KhungGioId",
                table: "timeSlots");

            migrationBuilder.DropIndex(
                name: "IX_timeSlots_KhungGioId",
                table: "timeSlots");

            migrationBuilder.DropColumn(
                name: "KhungGioId",
                table: "timeSlots");
        }
    }
}
