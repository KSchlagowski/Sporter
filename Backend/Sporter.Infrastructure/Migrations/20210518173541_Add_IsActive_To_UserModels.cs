using Microsoft.EntityFrameworkCore.Migrations;

namespace Sporter.Infrastructure.Migrations
{
    public partial class Add_IsActive_To_UserModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserModels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserModels");
        }
    }
}
