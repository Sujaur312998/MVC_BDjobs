using Microsoft.EntityFrameworkCore.Migrations;

namespace web_Bdjobs.Migrations
{
    public partial class add_cv_part : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cv",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cv",
                table: "User");
        }
    }
}
