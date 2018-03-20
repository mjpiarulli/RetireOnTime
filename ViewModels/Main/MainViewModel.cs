using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.Main
{
    public class MainViewModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("projectedIncomePerMonth")]
        public string ProjectedIncomePerMonth { get; set; }

        [JsonProperty("goal")]
        public string Goal { get; set; }

        [JsonProperty("percentThere")]
        public string PercentThere { get; set; }
    }
}