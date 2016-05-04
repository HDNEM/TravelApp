'use strict';

angular.module('app.services').service("TripsService", ['$http', function ($http) {

    function _getAllTrips() {
        return $http.get('/api/TripsController/Get/')
    }

    function _getTripById(id) {
        return $http.get('/api/TripsController/Get/' + id)
    }

    function _insert(trip) {
        return $http.post('/api/TripsController/Post/', trip)
    }

    return {
        getAllTrips: _getAllTrips,
        getTripById: _getTripById,
        insert: _insert
    }

}]);