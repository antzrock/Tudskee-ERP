(function (app) {
    'use strict';

    app.controller('loginCtrl', loginCtrl);

    loginCtrl.$inject = ['$scope', '$rootScope', '$location', 'baseUrl', 'localStorageService', 'notificationService'];

    function loginCtrl($scope, $rootScope, $location, baseUrl, localStorageService, notificationService) {

        $scope.loginViewModel = {};
        $scope.login = login;
        
        function login()
        {
            $scope.setUserFullname("Antonio Amiel L. Yap");
            notificationService.displaySuccess('Hello ' + $scope.user.Fullname);
            $scope.setIsUserLoggedIn(true);
            $location.path('/dashboard');
        }
    }

})(angular.module('common.core'));