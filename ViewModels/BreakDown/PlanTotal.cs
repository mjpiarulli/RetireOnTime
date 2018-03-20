using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.BreakDown
{
    public class PlanTotal
    {
        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("averageMonthlyIncome")]
        public string AverageMonthlyIncome { get; set; }
    }
}