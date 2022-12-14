using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS_WEB_API.Migrations
{
    public partial class newpropaddedinleave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveDetails_Employees_EmployeeId",
                table: "LeaveDetails");

            migrationBuilder.DropIndex(
                name: "IX_LeaveDetails_EmployeeId",
                table: "LeaveDetails");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "LeaveDetails",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveDetails_EmployeeId",
                table: "LeaveDetails",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveDetails_Employees_EmployeeId",
                table: "LeaveDetails",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
