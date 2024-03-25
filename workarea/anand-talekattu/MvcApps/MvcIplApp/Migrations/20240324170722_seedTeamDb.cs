using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcIplApp.Migrations
{
    /// <inheritdoc />
    public partial class seedTeamDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
