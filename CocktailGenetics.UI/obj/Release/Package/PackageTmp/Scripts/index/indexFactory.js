/// <reference path="indexModule.js" />

indexApp.factory('indexFactory', function($http) {
    var factory = {};
    var url = '/api/index';

    factory.getAllRecipesAndIngredientsUserChoice = function (id) {
        return $http.get(url + '/' + id);
    };

    factory.getAllRecipesAndIngredientsDefault = function() {
        return $http.get(url);
    };

    return factory;
});