using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_1.Migrations
{
    /// <inheritdoc />
    public partial class Populate_MemebershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MemebershipType (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (1,1000,3,10) ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
