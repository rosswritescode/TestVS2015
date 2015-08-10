(function () {
    'use strict';

    angular
        .module('demo_app')
        .factory('factory', factory);

    factory.$inject = ['$http'];

    function factory($http) {
        var service = {
            getData: getData
        };

        return service;

        function getData() { }
    }
    console.log("Angular factory")
})();