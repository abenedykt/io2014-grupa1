angular.module('fizzBuzzApp', [])
.controller('gameController', ['$scope', function ($scope) {
	$scope.result = '';
	$scope.button = {};
	$scope.button.clk = function() {
		$scope.result = '1 2 Fizz 4 Buzz 6 7 8 FizzBuzz 10 11 Buzz';
	}
}]);

angular.element(document).ready(function() {
	angular.bootstrap(document, ['fizzBuzzApp']);
});