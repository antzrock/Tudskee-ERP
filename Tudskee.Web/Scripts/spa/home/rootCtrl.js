(function (app) {
    'use strict';

    app.controller('rootCtrl', rootCtrl);

    rootCtrl.$inject = ['$scope', '$location', '$rootScope', 'baseUrl', 'localStorageService'];

    function rootCtrl($scope, $location, $rootScope, baseUrl, localStorageService) {

    }

})(angular.module('tudskee_erp'));