(function () {
    'use strict';

    angular.module('tudskee_erp', ['common.core', 'common.ui'])
        .config(config)
        .run(run)
        .constant('baseUrl', {
            //web: 'http://<server_name_here>:52108/',
            web: 'http://localhost:52108/',
        });

    config.$inject = ['$routeProvider', '$locationProvider'];
    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "scripts/spa/login/login.html",
                controller: "loginCtrl"
            })
            .when("/dashboard", {
                templateUrl: "scripts/spa/dashboard/dashboard.html",
                controller: "dashboardCtrl"
            })
            .otherwise({ redirectTo: "/" });


        if (window.history && window.history.pushState) {
            $locationProvider.html5Mode(true);
        }
    }

    run.$inject = ['$rootScope', '$location', '$cookieStore', '$http'];

    function run($rootScope, $location, $cookieStore, $http) {
        
    }

})();