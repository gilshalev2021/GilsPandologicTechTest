using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PandologicTechTestApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobStatisticsPoints",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveJobs = table.Column<int>(type: "int", nullable: false),
                    CumulativeJobViews = table.Column<int>(type: "int", nullable: false),
                    CumulativePredictedJobView = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobStatisticsPoints", x => x.Id);
                });
            for (int i = 1; i < 31; i++)
            {
                var dayDate = "2022-04-" + i;
                Random rnd = new Random();
                var activeJobs = rnd.Next(10, 400);
                var cumulativeJobViews = activeJobs + rnd.Next(10, 50);
                var CumulativePredictedJobView = cumulativeJobViews + rnd.Next(10, 50);
                migrationBuilder.InsertData(
                  table: "JobStatisticsPoints",
                  columns: new[] { "DayDate", "ActiveJobs", "CumulativeJobViews", "CumulativePredictedJobView" },
                  values: new object[] { dayDate, activeJobs, cumulativeJobViews, CumulativePredictedJobView });
            }
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobStatisticsPoints");
        }
    }
}
