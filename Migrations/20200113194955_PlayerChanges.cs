using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketApp.Migrations
{
    public partial class PlayerChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
