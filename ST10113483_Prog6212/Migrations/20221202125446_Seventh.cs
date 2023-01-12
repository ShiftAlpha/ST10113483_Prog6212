using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST101113483_Prog6212.Migrations
{
    /// <inheritdoc />
    public partial class Seventh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Module_User_username",
                table: "Module");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Module",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Module_User_username",
                table: "Module",
                column: "username",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Module_User_username",
                table: "Module");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Module",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddForeignKey(
                name: "FK_Module_User_username",
                table: "Module",
                column: "username",
                principalTable: "User",
                principalColumn: "username");
        }
    }
}
