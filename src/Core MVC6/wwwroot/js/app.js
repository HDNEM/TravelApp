(function () {
    'use strict';

    var app = angular.module('app', [
        'ngRoute']);

});

app.config(['$routeProvider',
function ($routeProvider) {
    $routeProvider.
      when('/trips', {
          templateUrl: '/templates/trips.html', controller: 'tripsController'
      }),
      when('/edit', {
          templateUrl: '/templates/editor.html', controller: 'tripEditorController'
      })
}]);