angularBomApp.factory('tlService',
    ["$http",
    function ($http) {

        var searchTitle = function(title) {
            return $http.post("/Home/SearchTitle", title);
        }

        return {
            searchTitle: searchTitle
        }
    }]);