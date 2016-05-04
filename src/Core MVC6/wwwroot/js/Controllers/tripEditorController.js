(function () {
    'use strict';

    angular
        .module('app')
        .controller('tripEditorController', tripEditorController);

    tripEditorController.$inject = ['$scope']; 

    function tripEditorController($scope) {
        $scope.title = 'tripEditorController';

        activate();

        function activate() { }
    }
})();
