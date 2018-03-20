using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.BreakDown
{
    public class Plan
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }

        [JsonProperty("averageMonthlyIncome")]
        public string AverageMonthlyIncome { get; set; }
    }
}