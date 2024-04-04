using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedingValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateOfBirth", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adi.@gmail.com", "Adi", "Adi" },
                    { 2, new DateTime(2001, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abhi.@gmail.com", "Abhi", "Abhi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);
        }
    }
}
