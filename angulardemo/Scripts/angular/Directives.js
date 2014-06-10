'use strict';

LeiDemoApp.directive('bigBanner', function () {  
    return {
        restrict: 'A',
        templateUrl: 'Scripts/angular/directivetemplates/bigbanner.html'      
    }
});



LeiDemoApp.directive('bigBanner2', function () {
    return {
        restrict: 'A',
        templateUrl: 'Scripts/angular/directivetemplates/bigbanner2.html',
        scope: {
            bannertitle: '@',
            bannertext:'@'
        }
    }
});

