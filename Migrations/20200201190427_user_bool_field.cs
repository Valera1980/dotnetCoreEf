using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthApi.Migrations
{
    public partial class user_bool_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWorker",
                table: "Users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWorker",
                table: "Users");
        }
    }
}
