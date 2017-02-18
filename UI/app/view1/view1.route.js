(function () {
    'use strict';

    angular
        .module('myApp.view1')
        .config(configRoutes);

     function configRoutes($stateProvider) {

        $stateProvider.state('view1',
            {
                url: "/view1",
                templateUrl: 'app/view1/view1.html',
                controller: 'View1Ctrl',
                controllerAs: 'vm',
                title: 'Members List',
                resolve: {
                    /* @ngInject */
                    allMembers: function (dataService) {
                       return dataService.getAllMembers()
                                .then(function (data) {
                                    return data;
                                }).catch(function (error) {
                                    console.log(error);
                            });
                            
                }
            }
    })

}
})();