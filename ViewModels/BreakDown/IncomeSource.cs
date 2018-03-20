using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.BreakDown
{
    public class IncomeSource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("averageMonthlyIncome")]
        public string AverageMonthlyIncome { get; set; }
    }
}