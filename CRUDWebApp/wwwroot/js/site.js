// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
(function () {
    //Module 
    var app = angular.module('MyApp', []);
    // Controller
    app.controller('MyController', function ($scope) {
        $scope.Message = "Congratulation you have created your first application using AngularJs";
    });
})();