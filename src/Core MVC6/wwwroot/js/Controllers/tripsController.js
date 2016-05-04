(function () {
    'use strict';

    angular
        .module('app')
        .controller('tripsController', controller);

    controller.$inject = ['$scope', 'TripsService', '$location'];

    function controller($scope, TripsService, $location) {
        $scope.title = 'controller';

        var tripsList = TripsService.getAllTrips();
        $scope.trip = tripsList;

        $scope.edit = function () {
            $location.path("/editor", $scope.trip);
        }

        activate();

        function activate() { }
    }
})();