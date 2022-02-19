using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingTracker.Service.Managers;
using ShoppingTracker.Service.Models;

namespace ShoppingTracker.Service.Controllers.v1
{
    [Route("[controller]")]
    [ApiController]
    public class TwitterStatisticsController : ControllerBase
    {
        private readonly ITwitterStatisticsManager _tweetComputationManager;

        public TwitterStatisticsController(ITwitterStatisticsManager tweetComputationManager)
        {
            _tweetComputationManager = tweetComputationManager;
        }     

        [HttpGet]
        public async Task<SampledTweetsStatistics> SampleTweetStatistics()
        {
            var tweets = await _tweetComputationManager.GetSampledTweetsStatistics();

            return tweets;
        }
    }
}
