using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPICodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class update_exam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hours",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassingMarks",
                table: "Exams",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "PassingMarks",
                table: "Exams");
        }
    }
}
