using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json;
using RetireOnTime.ViewModels.BreakDown;
using RetireOnTime.ViewModels.Details;
using RetireOnTime.ViewModels.EditGoals;
using RetireOnTime.ViewModels.Improve;
using RetireOnTime.ViewModels.Main;

namespace RetireOnTime.WebApiControllers
{
    [RoutePrefix("api/RotService")]
    public class RotServiceController : ApiController
    {
        [Route("GetBreakDown")]
        [HttpPost]
        public HttpResponseMessage GetBreakDown()
        {
            var vm = new BreakDownViewModel
            {
                Plans = new List<Plan>
                {
                    new Plan
                    {
                        Name = "A Penny Saved 401(k) Plan",
                        Balance = "$535,138.16",
                        AsOfDate = new DateTime(2017, 6, 16).ToString("MM/dd/yyyy"),
                        AverageMonthlyIncome = "$2,274.60"
                    }
                },
                PlanTotal = new PlanTotal
                {
                    Balance = "$535,138.16",
                    AverageMonthlyIncome = "$2,274.60"
                },
                OtherIncomeSources = new List<IncomeSource>
                {
                    new IncomeSource
                    {
                        Name = "Social Security",
                        AverageMonthlyIncome = "$2,288.00"
                    }
                },
                OtherIncomeSourceTotal = "$2,288.00",
                TotalRetirementIncomePerMonth = "$4,562.60"
            };
            var response = CreateHttpResponseMessage(vm);

            return response;
        }

        [Route("GetDetail")]
        [HttpPost]
        public HttpResponseMessage GetDetail()
        {
            var vm = new DetailsViewModel
            {
                CurrentContributionIncreasePercent = "2.50%",
                EffectiveIncomeTaxRate = "15.00%",
                InvestmentPortfolio = "Conservative",
                CashEquivalents = "15.0%",
                InterTermGovtBond = "25.0%",
                LongTermGovtBond = "15.0%",
                CorporateBonds = "15.0%",
                LargeValueStocks = "15.0%",
                LargeGrowthStocks = "10.0%",
                InternationalStocks = "3.0%",
                InternationalBonds = "3.0%",
                AverageAnnualReturn = "5.56%",
                StandardDeviation = "6.07%",
                AssumedEffectiveIncomeTaxRate = "10.00%",
                FirstYearPlanWithdrawal = "5.04%",

                Simulations = "2500",
                ConfidencePercent = "70.00%",
                MaxAge = "90",
                MonthlyWithdrawal = "$4,563",
                Inflation = "2.50%",
            };
            var response = CreateHttpResponseMessage(vm);

            return response;
        }

        [Route("GetEditGoals")]
        [HttpPost]
        public HttpResponseMessage GetEditGoals()
        {
            var vm = new EditGoalsViewModel
            {
                Monthly = "$8,333.33",
                Annually = "$100,000.00",
                RetirementBeginAge = "65",
                RetirementEndAge = "90"
            };
            var response = CreateHttpResponseMessage(vm);

            return response;
        }

        [Route("GetImprove")]
        [HttpPost]
        public HttpResponseMessage GetImprove()
        {
            var vm = new ImproveViewModel
            {
                OldAmount = "$4,562.60",
                NewAmount = "$4,564.00"
            };
            var response = CreateHttpResponseMessage(vm);

            return response;
        }

        [Route("GetMain")]
        [HttpPost]
        public HttpResponseMessage GetMain()
        {
            var vm = new MainViewModel
            {
                Title = "RetireOnTime",
                ProjectedIncomePerMonth = "$4,5620",
                Goal = "$8,333",
                PercentThere = "55%"
            };
            var response = CreateHttpResponseMessage(vm);

            return response;
        }

        private static HttpResponseMessage CreateHttpResponseMessage(object vm)
        {
            var json = JsonConvert.SerializeObject(vm);
            var response = new HttpResponseMessage
            {
                Content = new StringContent(json)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return response;
        }
    }
}