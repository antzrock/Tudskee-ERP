(function (app) {
    'use strict';

    app.controller('dashboardCtrl', dashboardCtrl);

    dashboardCtrl.$inject = ['$scope', '$rootScope', '$location', 'baseUrl', 'localStorageService'];

    function dashboardCtrl($scope, $rootScope, $location, baseUrl, localStorageService) {

    }

})(angular.module('common.core'));