using Microsoft.AspNetCore.Mvc;

namespace PandologicTechTestApi.Models
{
    public interface IJobStatisticsDataProvider
    {
        public Task<ActionResult<IEnumerable<JobStatisticsPoint>>> GetJobStatisticsPointsData(GetJobStatisticsRequest request);
    }
}
