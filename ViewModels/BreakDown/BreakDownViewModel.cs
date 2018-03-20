using System.Collections.Generic;
using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.BreakDown
{
    public class BreakDownViewModel
    {
        [JsonProperty("plans")]
        public IEnumerable<Plan> Plans { get; set; }

        [JsonProperty("planTotal")]
        public PlanTotal PlanTotal { get; set; }

        [JsonProperty("otherIncomeSources")]
        public IEnumerable<IncomeSource> OtherIncomeSources { get; set; }

        [JsonProperty("otherIncomeSourceTotal")]
        public string OtherIncomeSourceTotal { get; set; }

        [JsonProperty("totalRetirementIncomePerMonth")]
        public string TotalRetirementIncomePerMonth { get; set; }
    }
}