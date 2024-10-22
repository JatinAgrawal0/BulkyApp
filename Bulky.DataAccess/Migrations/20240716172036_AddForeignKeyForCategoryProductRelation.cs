using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    public partial class AddForeignKeyForCategoryProductRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "jatin_Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_jatin_Products_CategoryId",
                table: "jatin_Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_jatin_Products_jatin_Categories_CategoryId",
                table: "jatin_Products",
                column: "CategoryId",
                principalTable: "jatin_Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jatin_Products_jatin_Categories_CategoryId",
                table: "jatin_Products");

            migrationBuilder.DropIndex(
                name: "IX_jatin_Products_CategoryId",
                table: "jatin_Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "jatin_Products");
        }
    }
}
