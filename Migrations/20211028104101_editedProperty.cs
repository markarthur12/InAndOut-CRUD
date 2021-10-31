using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class editedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseTypes",
                table: "ExpenseTypes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ExpenseTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ExpenseTypes");

            migrationBuilder.AddColumn<string>(
                name: "ExpenseTypes",
                table: "ExpenseTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
