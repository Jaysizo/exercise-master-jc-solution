'use strict';

angular.module('myApp.viewDetails', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/viewDetails/:PersonId', {
    templateUrl: 'viewDetails/viewDetails.html',
    controller: 'ViewDetailsCtrl'
  });

  }])


.controller('ViewDetailsCtrl', [ '$scope', 'memberService', '$routeParams', function($scope, memberService, $routeParams) {
  	var memberId = $routeParams.PersonId;
    memberService.getMemberById(memberId).then(function(data) {
      $scope.member = data;
      $scope.currentMemberId = data.PersonId;
      $scope.memberService = memberService;
  });
   
   $scope.submitMember = function() {
      if($scope.member) {
        var memberModel = {
            "FirstName": $scope.member.FirstName,
            "LastName": $scope.member.LastName,
            "JobTitle": $scope.member.JobTitle,
            "PersonId": $scope.currentMemberId
        };
        $scope.memberService.updateMember(memberModel);
      }

    }



   }]);

