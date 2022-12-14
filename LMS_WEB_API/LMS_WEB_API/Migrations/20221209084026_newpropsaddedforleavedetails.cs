using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS_WEB_API.Migrations
{
    public partial class newpropsaddedforleavedetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AppliedOn",
                table: "LeaveDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ManagerComments",
                table: "LeaveDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "LeaveDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppliedOn",
                table: "LeaveDetails");

            migrationBuilder.DropColumn(
                name: "ManagerComments",
                table: "LeaveDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "LeaveDetails");
        }
    }
}
