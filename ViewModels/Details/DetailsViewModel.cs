using Newtonsoft.Json;

namespace RetireOnTime.ViewModels.Details
{
    public class DetailsViewModel
    {
        [JsonProperty("currentContributionIncreasePercent")]
        public string CurrentContributionIncreasePercent { get; set; }

        [JsonProperty("effectiveIncomeTaxRate")]
        public string EffectiveIncomeTaxRate { get; set; }

        [JsonProperty("investmentPortfolio")]
        public string InvestmentPortfolio { get; set; }

        [JsonProperty("cashEquivalents")]
        public string CashEquivalents { get; set; }

        [JsonProperty("interTermGovtBond")]
        public string InterTermGovtBond { get; set; }

        [JsonProperty("longTermGovtBond")]
        public string LongTermGovtBond { get; set; }

        [JsonProperty("corporateBonds")]
        public string CorporateBonds { get; set; }

        [JsonProperty("largeValueStocks")]
        public string LargeValueStocks { get; set; }

        [JsonProperty("largeGrowthStocks")]
        public string LargeGrowthStocks { get; set; }

        [JsonProperty("internationalStocks")]
        public string InternationalStocks { get; set; }

        [JsonProperty("internationalBonds")]
        public string InternationalBonds { get; set; }

        [JsonProperty("averageAnnualReturn")]
        public string AverageAnnualReturn { get; set; }

        [JsonProperty("standardDeviation")]
        public string StandardDeviation { get; set; }

        [JsonProperty("assumedEffectiveIncomeTaxRate")]
        public string AssumedEffectiveIncomeTaxRate { get; set; }

        [JsonProperty("firstYearPlanWithdrawal")]
        public string FirstYearPlanWithdrawal { get; set; }

        [JsonProperty("simulations")]
        public string Simulations { get; set; }

        [JsonProperty("confidencePercent")]
        public string ConfidencePercent { get; set; }

        [JsonProperty("maxAge")]
        public string MaxAge { get; set; }

        [JsonProperty("monthlyWithdrawal")]
        public string MonthlyWithdrawal { get; set; }

        [JsonProperty("inflation")]
        public string Inflation { get; set; }
    }
}