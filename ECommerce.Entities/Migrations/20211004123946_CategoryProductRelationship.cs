using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Entities.Migrations
{
    public partial class CategoryProductRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBLProduct_CategoryId",
                table: "TBLProduct");

            migrationBuilder.CreateIndex(
                name: "IX_TBLProduct_CategoryId",
                table: "TBLProduct",
                column: "CategoryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBLProduct_CategoryId",
                table: "TBLProduct");

            migrationBuilder.CreateIndex(
                name: "IX_TBLProduct_CategoryId",
                table: "TBLProduct",
                column: "CategoryId");
        }
    }
}
