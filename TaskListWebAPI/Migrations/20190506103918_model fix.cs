using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskListWebAPI.Migrations
{
    public partial class modelfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nescription",
                table: "TaskItems",
                newName: "description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "TaskItems",
                newName: "nescription");
        }
    }
}
