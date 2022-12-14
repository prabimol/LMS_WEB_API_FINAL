using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS_WEB_API.Migrations
{
    public partial class onepropremovedfromemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveDetails_Employees_EmployeeId1",
                table: "LeaveDetails");

            migrationBuilder.DropIndex(
                name: "IX_LeaveDetails_EmployeeId1",
                table: "LeaveDetails");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "LeaveDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "LeaveDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveDetails_EmployeeId1",
                table: "LeaveDetails",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveDetails_Employees_EmployeeId1",
                table: "LeaveDetails",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
