/// <reference path="C:\Users\yangj\Source\Repos\BankProject\BankClient\BankClient\Scripts/angular.js" />

var myApp = angular.module("myApp", ['ui.router']);

myApp.config(function ($stateProvider, $urlRouterProvider) {
    $stateProvider
        .state('Login', {
            url: '/Login',
            templateUrl: 'Login.html'
            //template: '<b>This is login view</b>'

        })
         .state('Page1.ChildView', {
             url: '/ChildView',
             template: '<b>I am child nested view</b>'
         })
        .state('Page2', {
            url: '/Page1',
            templateUrl: 'Page2.html'
        })
});
