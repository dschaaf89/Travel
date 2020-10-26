using Microsoft.EntityFrameworkCore.Migrations;

namespace travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Rating", "ReviewDetails" },
                values: new object[,]
                {
                    { 1, "Seattle", "USA", 3, "Eh" },
                    { 2, "Portland", "USA", 3, "Crazy people" },
                    { 3, "Hawaii", "USA", 5, "Fun" },
                    { 4, "Cape Town", "South Africa", 4, "Nice" },
                    { 5, "Beijing", "China", 1, "Ugh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);
        }
    }
}
