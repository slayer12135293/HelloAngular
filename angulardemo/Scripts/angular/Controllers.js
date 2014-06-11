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

LeiDemoApp.controller('Link2controller', ['$scope','dataService', function ($scope) {

    $scope.bigBanner = { header: 'Welcome to Link2', text: 'just as amazing as link1' }

  
    $scope.popover1 = {
        imageurl: 'http://lakernation.com/forums/public/style_emoticons/default/homer.gif',
        id: 'popover1',
        text: 'this is a popover text'
    };

    

}]);