using Microsoft.EntityFrameworkCore.Migrations;

namespace ColombianFood.Web.Data.Migrations
{
    public partial class addMenuItem7ToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_SubCategory_SubCategoryId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_SubCategoryId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "MenuItem");

            migrationBuilder.RenameColumn(
                name: "SubcategoryId",
                table: "MenuItem",
                newName: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_SubCategoryId",
                table: "MenuItem",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_SubCategory_SubCategoryId",
                table: "MenuItem",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_SubCategory_SubCategoryId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_SubCategoryId",
                table: "MenuItem");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "MenuItem",
                newName: "SubcategoryId");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "MenuItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_SubCategoryId",
                table: "MenuItem",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_SubCategory_SubCategoryId",
                table: "MenuItem",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
