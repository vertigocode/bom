angularBomApp
    .directive('titleLookupForm',
    function() {
        return {
            restrict: 'E',
            templateUrl: '/app/TitleLookup/tlTemplate.html'
        }
    })
    .directive('titleResultsForm',
    function() {
        return {
            restrict: 'E',
            templateUrl: '/app/TitleLookup/tlResultsTemplate.html'
        }
    });