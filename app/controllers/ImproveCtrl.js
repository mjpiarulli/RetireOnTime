(function () {
    'use strict';

    angular
        .module('app')
        .controller('ImproveCtrl', ["RotService", function (RotService) {
            var vm = this;
            vm.slider = {
                value: 10,
                options: {
                    floor: 10,
                    ceil: 1500,
                    step: 10
                }
            };
            RotService.getImprove().then(function(data) {
                vm.oldAmount = data.data.oldAmount;
                vm.newAmount = data.data.newAmount;
            });
        }]);
})();