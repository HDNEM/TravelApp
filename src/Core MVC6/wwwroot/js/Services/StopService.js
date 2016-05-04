'use strict';

angular.module('app.services').service("StopService", ['$http', function ($http) {

    function _getStop(tripName) {
        return $http.get('/api/StopsController/Get/', tripName)
    }

    function _insert(stop) {
        return $http.post('/api/StopsController/Post/', stop)
    }

    return {
        getAllTrips: _getAllTrips,
        getTripById: _getTripById,
        insert: _insert
    }

}]);