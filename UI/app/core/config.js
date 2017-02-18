(function() {
    'use strict';

    var core = angular.module('myApp.core', []);

    var config = {
        appTitle: 'MyApp',
        version: '1.0.0',
        webApiUrl: 'http://localhost:4001/'
    };

    core.value('config', config);
})();
