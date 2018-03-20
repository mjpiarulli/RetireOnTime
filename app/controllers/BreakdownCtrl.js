(function () {
    'use strict';

    angular
        .module('app')
        .controller('BreakdownCtrl', ["RotService", function (RotService) {
            var vm = this;
            RotService.getBreakDown().then(function(data) {
                vm.plans = data.data.plans;
                vm.planTotal = data.data.planTotal;
                vm.otherIncomeSources = data.data.otherIncomeSources;
                vm.otherIncomeSourcesTotal = data.data.otherIncomeSourcesTotal;
                vm.totalRetirementIncomePerMonth = data.data.totalRetirementIncomePerMonth;
            });
        }]);
})();