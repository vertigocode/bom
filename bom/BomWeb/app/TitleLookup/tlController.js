angularBomApp.controller('tlController',
    function tlController($scope, tlService) {


        $scope.searchTitle = function () {

            tlService.searchTitle($scope.search).then(
                function (results) {
                    $scope.movie = results.data.movies[0];
                    $scope.book = results.data.books[0];
                    $scope.showResults = true;
                    // on success 
                },
                function(results) {
                   // on error
                });

        }
    });