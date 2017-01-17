/// <reference path="C:\Users\yangj\Source\Repos\BankProject\BankClient\BankClient\Scripts/angular.js" />

var myApp = angular.module("myApp", ['ui.router']);
myApp.controller("CheckingController", CheckingController);
//just for fun
myApp.config(function ($stateProvider, $urlRouterProvider) {
    $stateProvider
        .state('Login', {
            url: '/Login',
            templateUrl: 'Login.html'
        })
         .state('Account', {
             url: '/Account',
             templateUrl: 'Account.html'
         })
        .state("Account.Checking", {
            url: '/Checking',
            templateUrl:'Checking.html'
        })
        .state("Account.CreditCard", {
            url: '/CreditCard',
            templateUrl:'CreditCard.html'
        })
        .state('Page2', {
            url: '/Page1',
            templateUrl: 'Page2.html'
        })
});
