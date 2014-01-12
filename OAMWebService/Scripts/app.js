

  var OAMApp = angular.module('OAMApp', ["ngRoute", "ngResource"]).
    config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/', { controller: CreateCtrl, templateUrl: 'apply.html' }).
        $routeProvider.when('/list', { controller: ListCtrl, templateUrl: 'list.html' }).
            otherwise({ redirectTo: '/' });
    } ]);
  OAMApp.factory('OAMApp', function ($resource) {
      return $resource('/api/Applications/:id', { id: '@id' }, { update: { method: 'PUT'} });
  });


  var ListCtrl = function ($scope, $location, OAMApp) {
      $scope.items = OAMApp.query();
  };

  var CreateCtrl = function ($scope, $location, OAMApp) {
      $scope.save = function () {
          OAMApp.save($scope.item, function () {
              $location.path('/new');
          });
      };

      $scope.IndustrySectors =
      ["Agriculture",
      "Accounting",
      "Advertising",
      "Aerospace",
      "Aircraft",
      "Airline",
      "Apparel & Accessories",
      "Automotive",
      "Banking",
      "Broadcasting",
      "Biotechnology",
      "Chemical",
      "Consulting",
      "Consumer Products",
      "Cosmetics",
      "Defense",
      "Department Stores",
      "Education",
      "Electronics",
      "Energy",
      "Entertainment & Leisure",

      ];
      
  };


