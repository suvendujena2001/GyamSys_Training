using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcIplApp.Migrations
{
    /// <inheritdoc />
    public partial class Addedsome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Title",
                keyValue: "CSK");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Title",
                keyValue: "DC");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Title",
                keyValue: "GT");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Title",
                keyValue: "KKR");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Title",
                keyValue: "LSG");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Title",
                keyValue: "RCB");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Captain", "Coach", "FullName", "Title", "Venue" },
                values: new object[,]
                {
                    { 1, "Ruturaj Gaikwad", "Stephen Fleming", "Chennai Super Kings", "CSK", "M. A. Chidambaram Stadium" },
                    { 2, "Rishabh Pant", "Ricky Ponting", "Delhi Capitals", "DC", "Arun Jaitley Stadium" },
                    { 3, "Faf du Plessis", "Sanjay Bangar", "Royal Challengers Bengaluru", "RCB", "M. Chinnaswamy Stadium" },
                    { 4, "Shubman Gill", "Ashish Nehra", "Gujarat Titans", "GT", "Narendra Modi Stadium" },
                    { 5, "Shreyas Iyer", "Chandrakant Pandit", "Kolkata Knight Riders", "KKR", "Eden Gardens" },
                    { 6, "KL Rahul", "Justin Langer", "Lucknow Super Giants", "LSG", "BRSABV Ekana Cricket Stadium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Title");

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Title", "Captain", "Coach", "FullName", "Id", "Venue" },
                values: new object[,]
                {
                    { "CSK", "Ruturaj Gaikwad", "Stephen Fleming", "Chennai Super Kings", 1, "M. A. Chidambaram Stadium" },
                    { "DC", "Rishabh Pant", "Ricky Ponting", "Delhi Capitals", 2, "Arun Jaitley Stadium" },
                    { "GT", "Shubman Gill", "Ashish Nehra", "Gujarat Titans", 4, "Narendra Modi Stadium" },
                    { "KKR", "Shreyas Iyer", "Chandrakant Pandit", "Kolkata Knight Riders", 5, "Eden Gardens" },
                    { "LSG", "KL Rahul", "Justin Langer", "Lucknow Super Giants", 6, "BRSABV Ekana Cricket Stadium" },
                    { "RCB", "Faf du Plessis", "Sanjay Bangar", "Royal Challengers Bengaluru", 3, "M. Chinnaswamy Stadium" }
                });
        }
    }
}
