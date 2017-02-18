(function () {
    'use strict';

    angular
        .module('myApp.core')
        .factory('dataService', dataService);

    /* @ngInject */
    function dataService (Shttp, $q, config) {
    	var webApiUrl = config.webApiUrl;

    	var service = {
    		getAllMembers: getAllMembers,
    		getMemberById: getMemberId,
    		updateMemberInformation : updateMemberInformation
    	};

    	function getAllMembers() {
    		return $http.get(webApiUrl + 'api/person')
                .then(function (res) {
                    return res.data;
                })
                .catch(function (error) {
                    return $q.reject('Error occured while retrieving all diseases: ' + error);
                });
        }

        function getMemberById (id) {
        	 return $http.get(webApiUrl + 'api/person/' + diseaseId)
                .then(function (res) {
                    return res.data;
                })
                .catch(function (error) {
                    return $q.reject('Error occured while retrieving all diseases: ' + error);
                });
        }

        function updateMemberInformation(personModel) {
        	 var urlEndPoint = webApiUrl + 'api/person/updatePerson';
            return $http.post(urlEndPoint, navigationModel).
                success(function (data) {
                    return data;
                }).
                error(function (data) {
                    console.log('error');
                });
        }

        return service;
    }

})();