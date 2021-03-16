using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShopProject.Migrations
{
    public partial class PrDescriptionField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "Products",
                newName: "PrDescription");

            migrationBuilder.AddColumn<int>(
                name: "DateTime",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrColor",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrPrice",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrPriceSale",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrSize",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PrColor",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PrPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PrPriceSale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PrSize",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "PrDescription",
                table: "Products",
                newName: "ProductPrice");
        }
    }
}
