'use strict';

LeiDemoApp.controller('MainPageController', ['$scope', function ($scope) {
    $scope.teststring = "hello";



}]);

LeiDemoApp.controller('Link1controller', ['$scope', function ($scope) {
    $scope.submitform = function (formObject, form) {
        if(form.$valid){
            alert("pass");
            console.log(form);
        }
    };

    $scope.bigBanner = { header: 'Welcome to Link1', text:'Lots of amazing things will happen here' }



}]);

LeiDemoApp.controller('Link2controller', ['$scope','dataService', function ($scope, dataService) {

    $scope.bigBanner = { header: 'Welcome to Link2', text: 'just as amazing as link1' }

    var promise = dataService.getData(3);

    

}]);