'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
				  'ngRoute',
				  'myApp.view1',
				  'myApp.view2',
				  'myApp.viewDetails',
				  'myApp.version'
				]).

factory('memberService', function($http, $q) {
		  var members = ["Peter", "Daniel", "Nina"];
		  var allMembers;
		  var webApiUrl = 'http://localhost:4001/'
		  
		  var service = {
		  	getAllMembers : getAllMembers,
		  	getMemberById : getMemberById,
		  	updateMember : updateMember
		  };

		  function getAllMembers() {
		  	var personListEndpoint = webApiUrl + 'api/person';
		  	return $http.get(personListEndpoint)
                .then(function (res) {
                    return res.data;
                })
                .catch(function (error) {
                    return $q.reject('Error occured while retrieving all members: ' + error);
                });
		  }

		  function getMemberById(memberId) {
		  	var personListEndpoint = webApiUrl + 'api/person/' + memberId.toString();
		  	return $http.get(personListEndpoint)
                .then(function (res) {
                    return res.data;
                })
                .catch(function (error) {
                    return $q.reject('Error occured while retrieving all members: ' + error);
                });
		  }

		   function updateMember(memberModel) {
		   	var urlEndPoint = webApiUrl + 'api/person/' + memberModel.PersonId.toString();
            return $http.post(urlEndPoint, memberModel).
                success(function (data, status, headers, config) {
                    console.log('member update is a success !');
                    return data;
                }).
                error(function (data, status, headers, config) {
                    console.log('error');
                });
		   }

		  return {
		    getAllMembers: function() {
		      return getAllMembers();
		    },
		    getMemberById: function(memberId) {
		      return getMemberById(memberId);
		    },
		    updateMember: function(memberModel) {
		    	return updateMember (memberModel);
		    },

		    service : function () {
		    	return service;
		    } 
		  }
		})

 .config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
					  $locationProvider.hashPrefix('!');
					  $routeProvider.otherwise({redirectTo: '/view1'});
				}]);
