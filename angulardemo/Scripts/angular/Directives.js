

LeiDemoApp.directive('bigBanner', function () {
    'use strict';
    return {
        restrict: 'A',
        templateUrl: 'Scripts/angular/directivetemplates/bigbanner.html'
    };
});



LeiDemoApp.directive('bigBanner2', function () {
    'use strict';
    return {
        restrict: 'A',
        templateUrl: 'Scripts/angular/directivetemplates/bigbanner2.html',
        scope: {
            bannertitle: '@',
            bannertext: '@'
        }
    };
});


LeiDemoApp.directive('popOver', function () {
    'use strict';
    return {
        restrict: 'AE',
        templateUrl: 'Scripts/angular/directivetemplates/popover.html',
        scope: {
            templateModel: '=templatemodel'
        },
        controller: function($scope) {
            $scope.togglepopover = function(targetId) {
                $("#" + targetId).toggle();
            };
            $scope.hideme = function(targetId) {
                $("#" + targetId).hide();
            };

        }
    };

});
