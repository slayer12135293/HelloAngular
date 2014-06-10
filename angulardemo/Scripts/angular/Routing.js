'use strict';

LeiDemoApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/link1', {
        templateUrl: '/link1',
        controller: 'Link1controller',
        reloadOnSearch: false
    }).when('/link2', {
        templateUrl: '/link2',
        controller: 'Link2controller',
        reloadOnSearch: false
    }).when('/', {
        templateUrl: '/MainPage',
        controller: 'MainPageController',
        reloadOnSearch: false
    }).otherwise({
        redirectTo: '/',
        reloadOnSearch: false
    });

   // $locationProvider.html5Mode(true);
}]);

