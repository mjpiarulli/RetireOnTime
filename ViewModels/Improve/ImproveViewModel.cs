using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.Improve
{
    public class ImproveViewModel
    {
        [JsonProperty("oldAmount")]
        public string OldAmount { get; set; }

        [JsonProperty("newAmount")]
        public string NewAmount { get; set; }
    }
}