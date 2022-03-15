using Microsoft.EntityFrameworkCore.Migrations;

namespace BigJigSaw.Migrations
{
    public partial class addModelItemNameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cena",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Item");
        }
    }
}
