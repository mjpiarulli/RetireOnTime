(function () {
    'use strict';

    angular
        .module('app')
        .controller('MainCtrl', ['ModalService', "RotService", function (ModalService, RotService) {
            var vm = this;
            RotService.getMain().then(function(data) {
                vm.title = 'RetireOnTime';
                vm.projectedIncomePerMonth = '$4,562.60';
                vm.goal = '$8,333';
                vm.percentThere = '55%';
            });

            vm.showImproveModal = function () {
                ModalService.showModal({
                    templateUrl: 'improveModal.html',
                    controller: 'ImproveCtrl',
                    controllerAs: 'vm'
                }).then(function (modal) {
                    modal.element.modal();
                    modal.close.then(function () { });
                }).catch(function (error) {
                    console.log(error);
                });
            };
        }]);
})();