using Microsoft.EntityFrameworkCore.Migrations;

namespace BookCatalog.Statistics.Data.Migrations
{
    public partial class InitStatisticDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    StatisticId = table.Column<string>(nullable: false),
                    TotalAuthors = table.Column<int>(nullable: false),
                    TotalBooks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.StatisticId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");
        }
    }
}
