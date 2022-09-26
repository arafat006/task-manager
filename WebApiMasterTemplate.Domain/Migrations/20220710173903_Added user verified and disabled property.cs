using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMasterTemplate.Domain.Migrations
{
    public partial class Addeduserverifiedanddisabledproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "User");
        }
    }
}
