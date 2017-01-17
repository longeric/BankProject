﻿/// <reference path="C:\Users\yangj\Source\Repos\BankProject\BankClient\BankClient\Scripts/angular.js" />

var myApp = angular.module("myApp", ['ui.router']);
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
            template:'<b>This is Checking Account</b>'
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
