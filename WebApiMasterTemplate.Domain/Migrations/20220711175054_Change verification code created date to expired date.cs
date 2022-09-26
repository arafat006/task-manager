using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMasterTemplate.Domain.Migrations
{
    public partial class Changeverificationcodecreateddatetoexpireddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Verification");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredDate",
                table: "Verification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiredDate",
                table: "Verification");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Verification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 13, 46, 21, 386, DateTimeKind.Utc).AddTicks(3131));
        }
    }
}
