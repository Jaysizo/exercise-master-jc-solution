'use strict';

angular.module('myApp.view1', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/view1', {
    templateUrl: 'view1/view1.html',
    controller: 'View1Ctrl'
  });

  }])


.controller('View1Ctrl', [ '$scope', 'memberService', function($scope, memberService) {
	//Injecting a service in order to retrieve the data from the API
   	memberService.getAllMembers().then(function(data) {
   			$scope.members = data;
   	});

   }]);



