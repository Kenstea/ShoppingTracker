using Newtonsoft.Json;

namespace ShoppingTracker.Service.Models
{
    /// <summary>
    /// Represent a tweet sampled from stream.
    /// </summary>
    public class SampledTweet
    {
        [JsonProperty("data")]        
        public Tweet Tweet { get; set; }
    }
}