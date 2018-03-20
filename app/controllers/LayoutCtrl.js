(function () {
    'use strict';

    angular
        .module('app')
        .controller('LayoutCtrl', ['ModalService', function (ModalService) {
            var vm = this;
            vm.showImproveModal = function () {
                ModalService.showModal({
                    templateUrl: 'improveModal.html',
                    controller: 'ImproveCtrl',
                    controllerAs: 'vm'
                }).then(function (modal) {
                    modal.element.modal();
                    modal.close.then(function (result) {
                    });
                }).catch(function(error) {
                    console.log(error);
                });
            };
            vm.showBreakdownModal = function() {
                ModalService.showModal({
                    templateUrl: 'breakdownModal.html',
                    controller: 'BreakdownCtrl',
                    controllerAs: 'vm'
                }).then(function (modal) {
                    modal.element.modal();
                    modal.close.then(function (result) {
                    });
                }).catch(function (error) {
                    console.log(error);
                });
            };
            vm.showDetailModal = function () {
                ModalService.showModal({
                    templateUrl: 'detailModal.html',
                    controller: 'DetailCtrl',
                    controllerAs: 'vm'
                }).then(function (modal) {
                    modal.element.modal();
                    modal.close.then(function (result) {
                    });
                }).catch(function (error) {
                    console.log(error);
                });
            };
        }]);
})();