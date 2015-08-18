using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.UI.Models.Home;

namespace CocktailGenetics.UI.Controllers
{
    public class HomeController : Controller
    {
        private IIngredientRepository _ingredientRepo;

        public HomeController(IIngredientRepository ingredientRepo)
        {
            _ingredientRepo = ingredientRepo;
        }

        public ActionResult Index()
        {
            //get all ingredients from db
            var ingredients = _ingredientRepo.GetAllIngredients();

            //convert ingredient model to view model format
            var model = new HomeIndexViewModel();
            foreach (var ingredient in ingredients)
            {
                if (ingredient.IsLiquor)
                {
                    model.Ingredients.Add(new HomeIndexIngredient
                    {
                        IngredientId = ingredient.IngredientId,
                        Name = ingredient.Name
                    });
                }
            }

            return View(model);
        }

    }
}
