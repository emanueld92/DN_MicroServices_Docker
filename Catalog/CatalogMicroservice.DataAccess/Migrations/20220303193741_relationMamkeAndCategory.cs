using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogMicroservice.DataAccess.Migrations
{
    public partial class relationMamkeAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryIdCategory",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Makes_MakeIdMake",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "MakeIdMake",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryIdCategory",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryIdCategory",
                table: "Products",
                column: "CategoryIdCategory",
                principalTable: "Categories",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Makes_MakeIdMake",
                table: "Products",
                column: "MakeIdMake",
                principalTable: "Makes",
                principalColumn: "IdMake",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryIdCategory",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Makes_MakeIdMake",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "MakeIdMake",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryIdCategory",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryIdCategory",
                table: "Products",
                column: "CategoryIdCategory",
                principalTable: "Categories",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Makes_MakeIdMake",
                table: "Products",
                column: "MakeIdMake",
                principalTable: "Makes",
                principalColumn: "IdMake",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
