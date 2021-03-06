using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShopProject.Migrations
{
    public partial class UpdateOurWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "OurWork",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "OurWork");
        }
    }
}
