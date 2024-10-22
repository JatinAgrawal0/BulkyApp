using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    public partial class FkeyAUTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComapnyID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ComapnyID",
                table: "AspNetUsers",
                column: "ComapnyID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_jatin_Companies_ComapnyID",
                table: "AspNetUsers",
                column: "ComapnyID",
                principalTable: "jatin_Companies",
                principalColumn: "CompanyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_jatin_Companies_ComapnyID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ComapnyID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ComapnyID",
                table: "AspNetUsers");
        }
    }
}
