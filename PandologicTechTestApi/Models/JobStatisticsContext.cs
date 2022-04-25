using Microsoft.EntityFrameworkCore;

namespace PandologicTechTestApi.Models
{
    public class JobStatisticsContext : DbContext
    {
        public JobStatisticsContext(DbContextOptions<JobStatisticsContext> options)
            : base(options) 
        {

        }

        public DbSet<JobStatisticsPoint> JobStatisticsPoints { get; set; } = null!;
    }
}
