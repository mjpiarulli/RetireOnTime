(function () {
    'use strict';

    var app = angular.module('app', ['ngRoute', 'rzModule', 'angularModalService']);

    app.config(['$routeProvider', function ($routeProvider) {
        var templateUrlBase = "app/views/";
        $routeProvider
            .when("/",
            {
                templateUrl: templateUrlBase + "main.htm",
                controller: "MainCtrl as vm"
            })
            .when("/editGoals",
            {
                templateUrl: templateUrlBase + "editGoals.htm",
                controller: "EditGoalsCtrl as vm"
            });
    }]);
})();