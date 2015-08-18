using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CocktailGenetics.Data;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;
using CocktailGenetics.UI.Models.Admin;

namespace CocktailGenetics.UI.Controllers
{
    //[Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private ICocktailRepository _cocktailRepo;
        private ICocktailIngredientRepository _ciRepo;
        private IIngredientRepository _ingredientRepo;
        private IRecipeRespository _recipeRepo;

        public AdminController(ICocktailRepository cocktailRepo,
            ICocktailIngredientRepository ciRepo,
            IIngredientRepository ingredientRepo,
            IRecipeRespository recipeRepo)
        {
            _cocktailRepo = cocktailRepo;
            _ingredientRepo = ingredientRepo;
            _ciRepo = ciRepo;
            _recipeRepo = recipeRepo;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cocktails()
        {
            var model = new AdminCocktailsVM();
            model.Populate(_ingredientRepo.GetAllIngredients());

            return View(model);
        }

        [HttpPost]
        public ActionResult Cocktails(AdminCocktailsVM model)
        {
            if (ModelState.IsValid)
            {
                //add cocktail data to cocktail table
                var cocktailAdded = _cocktailRepo.AddCocktail(new Cocktail
                {
                    Name = model.Name,
                    ImgUrl = model.ImgUrl
                });

                //add cocktail/ingredient combo data to that table
                foreach (var ingredient in model.SelectedIngredients)
                {
                    _ciRepo.AddCocktailIngredient(new CocktailIngredient
                    {
                        CocktailId = cocktailAdded.CocktailId,
                        IngredientId = ingredient.Id,
                        Amount = ingredient.Amount
                    });
                }

                //add recipe data to recipe table
                foreach (var step in model.RecipeSteps)
                {
                    _recipeRepo.AddRecipe(new Recipe
                    {
                        CocktailId = cocktailAdded.CocktailId,
                        StepNumber = step.RecipeStepNumber,
                        Text = step.Text
                    });
                }

                //redirect to admin home
                return View("Index");
            }

            //otherwise something went wrong, send back to view
            return View(model);
        }

        [HttpGet]
        public ActionResult Ingredients()
        {
            var model = new AdminIngredientsVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Ingredients(AdminIngredientsVM model)
        {
            if (ModelState.IsValid)
            {
                //add all of the new ingredients to db
                foreach (var i in model.SelectedIngredients)
                {
                    _ingredientRepo.AddIngredient(new Ingredient
                    {
                        Name = i.Name,
                        IsLiquor = i.IsLiquor
                    });
                }
                return View("Index");
            }

            //otherwise something went wrong, send user back to view
            return View("Ingredients", model);
        }

        public PartialViewResult NewIngredientRow(int id)
        {
            var ingredient = new AdminAddIngredient
            {
                Id = id
            };
            ingredient.Populate(_ingredientRepo.GetAllIngredients());

            return PartialView("NewIngredientRow", ingredient);
        }

        public PartialViewResult NewRecipeStepRow(int id)
        {
            return PartialView("NewRecipeStepRow", new AdminAddRecipeStep
            {
                Id = id
            });
        }

        public PartialViewResult AddNewIngredient(int id)
        {
            var model = new AdminAddNewIngredient {Id = id};
            return PartialView(model);
        }
    }
}
