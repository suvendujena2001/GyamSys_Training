using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPICodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class updatequestionwithexamid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExanID_fk",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExanID_fk",
                table: "Questions");
        }
    }
}
