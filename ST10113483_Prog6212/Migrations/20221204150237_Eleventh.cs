using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST101113483_Prog6212.Migrations
{
    /// <inheritdoc />
    public partial class Eleventh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoursStudiedThisWeek",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "RecommendedStudyHours",
                table: "Module");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HoursStudiedThisWeek",
                table: "Module",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RecommendedStudyHours",
                table: "Module",
                type: "float",
                nullable: true);
        }
    }
}
