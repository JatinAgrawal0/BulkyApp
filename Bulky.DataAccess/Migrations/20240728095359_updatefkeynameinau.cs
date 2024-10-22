using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    public partial class updatefkeynameinau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_jatin_Companies_ComapnyID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ComapnyID",
                table: "AspNetUsers",
                newName: "CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ComapnyID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_jatin_Companies_CompanyID",
                table: "AspNetUsers",
                column: "CompanyID",
                principalTable: "jatin_Companies",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_jatin_Companies_CompanyID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "AspNetUsers",
                newName: "ComapnyID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CompanyID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ComapnyID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_jatin_Companies_ComapnyID",
                table: "AspNetUsers",
                column: "ComapnyID",
                principalTable: "jatin_Companies",
                principalColumn: "CompanyID");
        }
    }
}
