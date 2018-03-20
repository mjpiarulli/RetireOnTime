(function () {
    'use strict';

    angular
        .module('app')
        .service("RotService", function($http) {
            this.getBreakDown = function() {
                return $http.post("/api/RotService/GetBreakDown");
            };
            this.getDetail = function() {
                return $http.post("/api/RotService/GetDetail");
            };
            this.getEditGoals = function() {
                return $http.post("/api/RotService/GetEditGoals");
            };
            this.getImprove = function() {
                return $http.post("/api/RotService/GetImprove");
            };
            this.getMain = function() {
                return $http.post("/api/RotService/GetMain");
            };
        });
})();