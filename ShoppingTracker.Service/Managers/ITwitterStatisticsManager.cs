using System.Threading;
using System.Threading.Tasks;
using ShoppingTracker.Service.Models;

namespace ShoppingTracker.Service.Managers
{
    public interface ITwitterStatisticsManager
    {
        Task<SampledTweetsStatistics> GetSampledTweetsStatistics();
    }
}