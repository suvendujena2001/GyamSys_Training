using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_1.Migrations
{
    /// <inheritdoc />
    public partial class AddMemebershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "MemebershipTypeId",
                table: "Customers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "MemebershipType",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    SignUpFee = table.Column<short>(type: "smallint", nullable: false),
                    DurationInMonths = table.Column<byte>(type: "tinyint", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemebershipType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MemebershipTypeId",
                table: "Customers",
                column: "MemebershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MemebershipType_MemebershipTypeId",
                table: "Customers",
                column: "MemebershipTypeId",
                principalTable: "MemebershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MemebershipType_MemebershipTypeId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "MemebershipType");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MemebershipTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MemebershipTypeId",
                table: "Customers");
        }
    }
}
