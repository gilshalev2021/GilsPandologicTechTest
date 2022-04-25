using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PandologicTechTestApi.Models
{
    public class JobStatisticsDataProvider : IJobStatisticsDataProvider
    {
        private readonly JobStatisticsContext _context;
        public JobStatisticsDataProvider(JobStatisticsContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<JobStatisticsPoint>>> GetJobStatisticsPointsData(GetJobStatisticsRequest request)
        {
            return await _context.JobStatisticsPoints.Where(point => point.DayDate.Date >= request.Start.Date && point.DayDate.Date <= request.End.Date).OrderBy(x => x.DayDate).ToListAsync();
        }
    }
}
