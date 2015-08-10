(function () {
    'use strict';

    angular
        .module('demo_app')
        .controller('controller', controller);

    controller.$inject = ['$scope']; 

    function controller($scope) {
        $scope.title = 'controller';

        activate();

        function activate() { }
    }

    console.log("Angular controller")
})();
