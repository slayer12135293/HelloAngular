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


LeiDemoApp.directive('popover', function () {
    return {
        restrict: 'AE',
        templateUrl: 'Scripts/angular/directivetemplates/popover.html',
        scope: {
            templateModel: '=templatemodel'
        },
        controller: function($scope){
            $scope.togglepopover = function (targetId) {
                $("#"+id).toggle();
            }
            $scope.hideme = function(targetId){
                $("#"+targetId).hide();
            }

        }

    }

});
