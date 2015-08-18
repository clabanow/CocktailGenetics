/// <reference path="indexModule.js" />

indexApp.controller('IndexCtrl', function($scope, indexFactory) {

    function loadDefaultData() {
        indexFactory.getAllRecipesAndIngredientsDefault()
            .success(function(model) {
                $scope.ingredients = model.Ingredients;
                $scope.recipes = model.Recipes;
            })
            .error(function(status) {
                alert("Error! Status: " + status);
            });
    };

    function reloadAfterSelection(ingredientIdString) {
        indexFactory.getAllRecipesAndIngredientsUserChoice(ingredientIdString)
            .success(function(model) {
                $scope.recipes = model.Recipes;
            })
            .error(function(status) {
                alert("Error! Status: " + status);
            });
    }

    //load all ingredients and recipes on initial page load
    loadDefaultData();

    //empty array to be filled with selected ingredients
    $scope.selectedIngredients = [];

    //selects an ingredient to be added to list
    $scope.select = function (model) {
        var ingredient = {
            Name: model.Name,
            Id: model.IngredientId
        };

        var result = ingredientAlreadyInList($scope.selectedIngredients,
            ingredient);

        //check if ingredient is already in the list
        if (!result.inList) {
            //if not, add to list
            $scope.selectedIngredients.push(ingredient);
            model.Class = "clicked-ingredient";
        } else {
            //if so, remove from list
            $scope.selectedIngredients.splice(result.index, 1);
            model.Class = "";
        }

        //reloads cocktail recipe result data
        var selectedIngredientsIdString = [];
        for (var i = 0; i < $scope.selectedIngredients.length; i++) {
            selectedIngredientsIdString.push($scope.selectedIngredients[i].Id);
        }
        reloadAfterSelection(selectedIngredientsIdString.join());
    };

    //unselects an ingredient from the list and changes back coloring to normal
    $scope.unselect = function(model) {
        //remove ingredient from selected ingredient list
        $scope.select(model);

        //change color back to normal (i.e. white background instead of orange)
        changeModelClassToEmpty(model.Id);
    }

    //changes Class property to an empty string
    function changeModelClassToEmpty(id) {
        //loop through ingredients and find the matching one
        for (var i = 0; i < $scope.ingredients.length; i++) {
            if ($scope.ingredients[i].IngredientId == id) {
                $scope.ingredients[i].Class = "";
            }
        }
    }

    //checks if ingredient is already in list of selected ingredients
    function ingredientAlreadyInList(list, ingredientToAdd) {
        var i;
        for (i = 0; i < list.length; i++) {
            if (list[i].Name == ingredientToAdd.Name) {
                return {
                    inList: true,
                    index: i
                };
            }
        }
        return {
            inList: false,
            index: null
        };
    }
});