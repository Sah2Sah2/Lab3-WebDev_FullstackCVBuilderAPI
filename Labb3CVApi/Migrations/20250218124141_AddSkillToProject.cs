using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3CVApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SkillId",
                table: "Projects",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Skills_SkillId",
                table: "Projects",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Skills_SkillId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_SkillId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Projects");
        }
    }
}
