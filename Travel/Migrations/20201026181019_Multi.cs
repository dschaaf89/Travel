using Microsoft.EntityFrameworkCore.Migrations;

namespace travel.Migrations
{
    public partial class Multi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Destination", "Rating", "ReviewDetails" },
                values: new object[] { 6, "Portland", "USA", "Rose Garden", 2, "Crazy people" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);
        }
    }
}
