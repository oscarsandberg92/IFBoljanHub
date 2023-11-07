angular.module('umbraco').requires.push('ui.calendar');

angular.module('umbraco').controller('fullCalendarController', 
    ['$scope', '$log', 'uiCalendarConfig', '$timeout','FullCalendarResource',
    function($scope, $log, uiCalendarConfig, $timeout,FullCalendarResource) {

        $scope.uiCalendarConfig = uiCalendarConfig;
        $scope.events = [];
        $scope.eventSources = [];
        $scope.calendarConfig = {
            selectable: true,
            selectHelper: true,
            editable: true,
            header:{
                left: $scope.block.data.left,
                center: $scope.block.data.center,
                right: $scope.block.data.right
            }
        };

        FullCalendarResource.getEventsFromApi($scope.block.data.dataSource).then(function(response) {

            angular.forEach(angular.fromJson(response.data), function(item) {

                if (item.daysOfWeek) { //recurring event so create instances
                    angular.forEach(angular.fromJson(item.daysOfWeek),
                        function(dayOfWeek) {
                            const date = moment(item.startRecur);
                            const dow = date.isoWeekday();
                            // if we haven't yet passed the day of the week that I need:
                            if (dow <= dayOfWeek) { 
                                // then just give me this week's instance of that day
                                date.isoWeekday(dayOfWeek);  
                            } else {
                                // give me next week's instance of that day
                                date.add(1, "w");
                                date.isoWeekday(dayOfWeek);
                            }

                            while (date < moment(item.endRecur)) {
                                item.start = date.format("YYYY-MM-DD") + "Z" + item.startTime;
                                item.end = date.format("YYYY-MM-DD") + "Z" + item.endTime;
                                $scope.events.push({ id: $scope.generateGuid(), title: item.title, className:item.className, start: item.start, end: item.end, description: item.description, allDay: item.allDay });
                                date.add(1, "w");
                            }
                        });

                } else {
                    $scope.events.push({ id: $scope.generateGuid(), title: item.title, className:item.className, start: item.start, end: item.end, description: item.description, allDay: item.allDay });
                }

            });
            $scope.eventSources.push($scope.events);

        });

        $scope.generateGuid = function() {
            return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
                var r = Math.random() * 16 | 0,
                    v = c == 'x' ? r : (r & 0x3 | 0x8);
                return v.toString(16);
            });
        }
    }
]);