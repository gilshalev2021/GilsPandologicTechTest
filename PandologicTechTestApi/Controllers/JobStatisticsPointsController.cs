using Microsoft.AspNetCore.Mvc;
using PandologicTechTestApi.Models;

namespace PandologicTechTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobStatisticsPointsController : ControllerBase
    {
        private readonly IJobStatisticsDataProvider _dataProvider;

        public JobStatisticsPointsController(IJobStatisticsDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobStatisticsPoint>>> GetJobStatisticsPoints([FromQuery] GetJobStatisticsRequest request)
        {
            return await _dataProvider.GetJobStatisticsPointsData(request);
        }
        
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IEnumerable<JobStatisticsPoint>>> PostJobStatisticsPoint(GetJobStatisticsRequest request)
        {
            return await _dataProvider.GetJobStatisticsPointsData(request);
        }
    }
}