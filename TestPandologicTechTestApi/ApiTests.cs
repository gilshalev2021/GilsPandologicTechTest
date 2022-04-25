using Microsoft.EntityFrameworkCore;
using PandologicTechTestApi.Controllers;
using PandologicTechTestApi.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestPandologicTechTestApi
{
    public class ApiTests
    {
        [Fact]
        public async void SupplyValidRangeDates_ExpectToFindRecords()
        {
            //Arrange
            var start = new DateTime(2022, 4, 1);
            var end = new DateTime(2022, 4, 30);
            var getJobStatisticsRequest = new GetJobStatisticsRequest { Start = start, End = end };
            var contextOptions = new DbContextOptionsBuilder<JobStatisticsContext>()
                        .UseSqlServer(@"Data Source=gshalev6-MOBL\SQLEXPRESS;Initial Catalog=PandologicTechTest;Integrated Security=True")
                        .Options;
            var context = new JobStatisticsContext(contextOptions);
            var provider = new JobStatisticsDataProvider(context);
            var controller = new JobStatisticsPointsController(provider);

            //Act
            var result = await controller.GetJobStatisticsPoints(getJobStatisticsRequest);

            //Assert
            if (result.Result is ICollection<JobStatisticsPoint> arrResult)
            {
                Assert.True(arrResult.Count > 0, "Expected result to contain records.");
            }
            else
            {
                throw(new NullReferenceException());
            }
        }
    }
}