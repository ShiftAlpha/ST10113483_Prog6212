using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST101113483_Prog6212.Migrations
{
    /// <inheritdoc />
    public partial class Eighth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hoursStudiedToday",
                table: "Module");

            migrationBuilder.RenameColumn(
                name: "hoursStudiedThisWeek",
                table: "Module",
                newName: "HoursStudiedThisWeek");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HoursStudiedThisWeek",
                table: "Module",
                newName: "hoursStudiedThisWeek");

            migrationBuilder.AddColumn<double>(
                name: "hoursStudiedToday",
                table: "Module",
                type: "float",
                nullable: true);
        }
    }
}
