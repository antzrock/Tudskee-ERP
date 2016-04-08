(function (app) {
    'use strict';

    app.controller('rootCtrl', rootCtrl);

    rootCtrl.$inject = ['$scope', '$location', '$rootScope', 'baseUrl', 'localStorageService', 'notificationService'];

    function rootCtrl($scope, $location, $rootScope, baseUrl, localStorageService, notificationService) {

        $scope.user = {
            Fullname: ''
        };

        $scope.isUserLoggedIn = false;
        $scope.setIsUserLoggedIn = setIsUserLoggedIn;
        $scope.setUserFullname= setUserFullname;

        function setUserFullname(userName)
        {
            $scope.user.Fullname = userName;
        }

        function setIsUserLoggedIn(isLoggedIn)
        {
            $scope.isUserLoggedIn = isLoggedIn;
        }
    }

})(angular.module('tudskee_erp'));