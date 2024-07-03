using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAn2.Migrations
{
    public partial class Initdb10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeNow",
                table: "timeSlots");

            migrationBuilder.CreateTable(
                name: "khungGios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khungGios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "khungGios");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeNow",
                table: "timeSlots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
