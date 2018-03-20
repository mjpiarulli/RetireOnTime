(function () {
    'use strict';

    angular
        .module('app')
        .controller('EditGoalsCtrl', ["RotService", function (RotService) {
            var vm = this;
            RotService.getEditGoals().then(function(data) {
                vm.monthly = data.data.monthly;
                vm.annually = data.data.annually;
                vm.retirementBeginAge = data.data.retirementBeginAge;
                vm.retirementEndAge = data.data.retirementEndAge;
            });
        }]);
})();