using System.ComponentModel.DataAnnotations;

namespace PandologicTechTestApi.Models
{
    public class JobStatisticsPoint
    {
        public long Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DayDate { get; set; }
        public int ActiveJobs { get; set; }
        public int CumulativeJobViews { get; set; }
        public int CumulativePredictedJobView { get; set; }
    }
}
