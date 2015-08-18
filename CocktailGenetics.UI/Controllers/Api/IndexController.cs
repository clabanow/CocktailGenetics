using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using CocktailGenetics.Data;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;
using CocktailGenetics.UI.Models.Angular;

namespace CocktailGenetics.UI.Controllers.Api
{
    public class IndexController : ApiController
    {
        private static ICocktailRepository _cocktailRepo = RepoFactory.GetCocktailRepo();
        private static ICocktailIngredientRepository _ciRepo = RepoFactory.GetCocktailIngredientRepo();
        private static IIngredientRepository _ingredientRepo = RepoFactory.GetIngredientRepository();
        private static IRecipeRespository _recipeRepo = RepoFactory.GetRecipeRepo();

        private static List<IngredientAng> _liquorIngredients = _ingredientRepo.GetAllIngredients()
                    .Where(m => m.IsLiquor == true)
                    .Select(m => new IngredientAng
                    {
                        IngredientId = m.IngredientId,
                        Name = m.Name
                    })
                    .OrderBy(m => m.Name)
                    .ToList();
        private IndexAng model = new IndexAng
        {
            Ingredients = _liquorIngredients
        };
        
        public IndexAng Get()
        {
            List<int> allCocktailIds = _cocktailRepo.GetAllCocktails()
                                                .Select(m => m.CocktailId)
                                                .ToList();
            model.Recipes = GenerateRecipeListFromCocktailIds(allCocktailIds);

            return model;
        }

        public IndexAng Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return Get();
            }
            else
            {
                model.Ingredients = ReturnAllLiquorIngredients();
                model.Recipes = GetCocktailListBasedOnSelectedIngredientIds(id);
                return model;
            }
        }

        public List<IngredientAng> ReturnAllLiquorIngredients()
        {
            if (_liquorIngredients == null)
            {
                _liquorIngredients = _ingredientRepo.GetAllIngredients()
                    .Where(m => m.IsLiquor == true)
                    .Select(m => new IngredientAng
                    {
                        IngredientId = m.IngredientId,
                        Name = m.Name
                    })
                    .OrderBy(m => m.Name)
                    .ToList();
            }

            return _liquorIngredients;
        }

        public List<RecipeAng> GenerateRecipeListFromCocktailIds(List<int> cocktailIds)
        {
            var result = new List<RecipeAng>();

            foreach (var id in cocktailIds)
            {
                var cocktailRecipeToAdd = new RecipeAng();
                var cocktail = _cocktailRepo.GetCocktailById(id);
                cocktailRecipeToAdd.CocktailName = cocktail.Name;
                cocktailRecipeToAdd.ImgUrl = "/Content/img/" + cocktail.ImgUrl + ".jpg";

                //get all ingredients
                var ingredients = _ciRepo.GetAllIngredientsByCocktailId(id);
                foreach (var ing in ingredients)
                {
                    cocktailRecipeToAdd.Ingredients.Add
                        (ing.Amount + " " + _ingredientRepo.GetIngredientById(ing.IngredientId).Name);
                }

                //get all recipe steps
                cocktailRecipeToAdd.RecipeSteps =
                    _recipeRepo.GetAllRecipeStepsByCocktail(id).Select(m => m.StepNumber + ". " + m.Text).ToList();

                //add recipe to the model
                result.Add(cocktailRecipeToAdd);
            }

            return result.OrderBy(m => m.Ingredients.Count).ToList();
        } 

        public List<RecipeAng> GetCocktailListBasedOnSelectedIngredientIds(string idString)
        {
            var listOfFilteredCocktailIds = GetCocktailIdsBasedOnSelectedIngredientIds(idString);
            return GenerateRecipeListFromCocktailIds(listOfFilteredCocktailIds);
        }

        public List<int> GetCocktailIdsBasedOnSelectedIngredientIds(string idString)
        {
            var listOfFilteredCocktailIds = new List<int>();

            var listOfIngredientIdsForAllCocktails = GetListOfIngredientIdsForEachCocktailInDb();
            var selectedIngredientIdList = ConvertIdStringIntoArrayOfInts(idString);
            for (int cocktailId = 1; cocktailId <= listOfIngredientIdsForAllCocktails.Count; cocktailId++)
            {
                if (CocktailContainsAllIngredients(selectedIngredientIdList, listOfIngredientIdsForAllCocktails, cocktailId))
                {
                    listOfFilteredCocktailIds.Add(cocktailId);
                }
            }

            return listOfFilteredCocktailIds;
        }

        public bool CocktailContainsAllIngredients(int[] selectedIngredientIdList, List<List<int>> listOfIngredientIds, int cocktailId)
        {
            return !selectedIngredientIdList.Except(listOfIngredientIds[cocktailId - 1]).Any();
        }

        public List<List<int>> GetListOfIngredientIdsForEachCocktailInDb()
        {
            var allCockailIds = _cocktailRepo.GetAllCocktails().Select(m => m.CocktailId).ToList();
            List<List<int>> listOfIngredientIds = new List<List<int>>();

            foreach (var cocktailId in allCockailIds)
            {
                listOfIngredientIds.Add(_ciRepo.GetAllIngredientsByCocktailId(cocktailId).Select(m => m.IngredientId).ToList());
            }

            return listOfIngredientIds;
        } 

        public int[] ConvertIdStringIntoArrayOfInts(string idString)
        {
            return Array.ConvertAll(idString.Split(','), s => int.Parse(s));
        }
    }
}
