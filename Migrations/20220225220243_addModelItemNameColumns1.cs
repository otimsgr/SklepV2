using Microsoft.EntityFrameworkCore.Migrations;

namespace BigJigSaw.Migrations
{
    public partial class addModelItemNameColumns1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cena",
                table: "Item",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Item",
                newName: "Cena");
        }
    }
}
