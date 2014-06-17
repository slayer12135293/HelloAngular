//'use strict';

//LeiDemoApp.factory('dataService', ['$resource', '$q', function ($resource, $q) {
//    return {
//        getData: function(id) {
//            var defer = new $q.defer();
//            var url = 'http://www.thomas-bayer.com/sqlrest/CUSTOMER/';
//            $resource(url + '/:id', { id: '@id' }).get(
//                { id: 1 },
//                function(event) {
//                    defer.resolve(event);
//                },
//                function(response) {
//                    defer.reject(response);
//                }
//            );
//            return defer.promise;

//        }
//    };
//}])