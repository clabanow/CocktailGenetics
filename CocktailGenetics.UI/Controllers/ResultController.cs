using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;
using CocktailGenetics.UI.Models.Result;

namespace CocktailGenetics.UI.Controllers
{
    public class ResultController : Controller
    {
        private ICocktailRepository _cocktailRepo;
        private ICocktailIngredientRepository _ciRepo;
        private IIngredientRepository _ingredientRepo;

        public ResultController(ICocktailRepository cocktailRepo,
            ICocktailIngredientRepository ciRepo,
            IIngredientRepository ingredientRepo)
        {
            _cocktailRepo = cocktailRepo;
            _ingredientRepo = ingredientRepo;
            _ciRepo = ciRepo;
        }

        public ActionResult GetResults(int id)
        {
            var model = new ResultGetResultsViewModel();

            var filteredCocktails = _ciRepo.GetAllCocktailIngredients()
                .Where(m => m.IngredientId == id);

            //get a list of unique cocktails
            var cocktails = new List<Cocktail>();
            foreach (var item in filteredCocktails)
            {
                var name = _cocktailRepo.GetCocktailById(item.CocktailId).Name;
                if (!cocktails.Any(m => m.Name == name))
                {
                    cocktails.Add(_cocktailRepo.GetCocktailById(item.CocktailId));
                }
            }

            //add each cocktail to the VM list
            foreach (var item in cocktails)
            {
                var ingredients = _ciRepo.GetAllIngredientsByCocktailId(id).Select(m => m.CocktailId);
                var ingredientNames = new List<string>();
                foreach (var num in ingredients)
                {
                    ingredientNames.Add(_ingredientRepo.GetIngredientById(num).Name);
                }

                model.Cocktails.Add(new ResultGetResultsCocktails
                {
                    Name = item.Name,
                    RecipeLink = item.ImgUrl,
                    Ingredients = ingredientNames
                });
            }

            return View(model);
        }

    }
}
