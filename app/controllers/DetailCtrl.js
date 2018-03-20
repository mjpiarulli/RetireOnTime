(function () {
    'use strict';

    angular
        .module('app')
        .controller('DetailCtrl', ['RotService', function (RotService) {
            var vm = this;
            RotService.getDetail().then(function(data) {
                vm.currentContributionIncreasePercent = data.data.currentContributionIncreasePercent;
                vm.effectiveIncomeTaxRate = data.data.effectiveIncomeTaxRate;
                vm.investmentPortfolio = data.data.investmentPortfolio;
                vm.cashEquivalents = data.data.cashEquivalents;
                vm.interTermGovtBond = data.data.interTermGovtBond;
                vm.longTermGovtBond = data.data.longTermGovtBond;
                vm.corporateBonds = data.data.corporateBonds;
                vm.largeValueStocks = data.data.largeValueStocks;
                vm.largeGrowthStocks = data.data.largeGrowthStocks;
                vm.internationalStocks = data.data.internationalStocks;
                vm.internationalBonds = data.data.internationalBonds;
                vm.averageAnnualReturn = data.data.averageAnnualReturn;
                vm.standardDeviation = data.data.standardDeviation;
                vm.assumedEffectiveIncomeTaxRate = data.data.assumedEffectiveIncomeTaxRate;
                vm.firstYearPlanWithdrawal = data.data.firstYearPlanWithdrawal;

                vm.simulations = data.data.simulations;
                vm.confidencePercent = data.data.confidencePercent;
                vm.maxAge = data.data.maxAge;
                vm.monthlyWithdrawal = data.data.monthlyWithdrawal;
                vm.inflation = data.data.inflation;
            });
        }]);
})();