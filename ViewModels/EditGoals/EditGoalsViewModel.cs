using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.EditGoals
{
    public class EditGoalsViewModel
    {
        [JsonProperty("monthly")]
        public string Monthly { get; set; }

        [JsonProperty("annually")]
        public string Annually { get; set; }

        [JsonProperty("retirementBeginAge")]
        public string RetirementBeginAge { get; set; }

        [JsonProperty("retirementEndAge")]
        public string RetirementEndAge { get; set; }
    }
}