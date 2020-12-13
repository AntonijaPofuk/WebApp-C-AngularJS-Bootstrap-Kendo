var app = angular.module("mainApp", []);

app.controller("personCtrl", function ($scope) {
    $scope.firstName;
    $scope.lastName;
    $scope.fullName = function () {
        return $scope.firstName + " " + $scope.lastName;
    };
});