using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team1_HRMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "DailyReports");

            migrationBuilder.RenameColumn(
                name: "TaskName",
                table: "DailyReports",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "DailyReports",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "DailyReports",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "DailyReports",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DailyReports",
                newName: "TaskName");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "DailyReports",
                newName: "ProjectName");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "DailyReports",
                newName: "DueDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DailyReports",
                newName: "TaskId");

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "DailyReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
