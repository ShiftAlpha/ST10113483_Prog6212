using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST101113483_Prog6212.Migrations
{
    /// <inheritdoc />
    public partial class Ninth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RecommendedStudyHours",
                table: "Module",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecommendedStudyHours",
                table: "Module");
        }
    }
}
