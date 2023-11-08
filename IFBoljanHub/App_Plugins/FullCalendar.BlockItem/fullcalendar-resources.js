angular.module("umbraco.resources").factory("FullCalendarResource", function ($http) {
    return {
        getEventsFromApi: function (path) {
            return $http.get(path);
        }
    };
});