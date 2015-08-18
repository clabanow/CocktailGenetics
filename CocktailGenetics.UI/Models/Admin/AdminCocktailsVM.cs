using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CocktailGenetics.Models;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminCocktailsVM
    {
        public int CocktailId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You must enter a name")]
        public string Name { get; set; }

        [Display(Name = "Img Title")]
        [Required(ErrorMessage = "You must enter an Img Url")]
        public string ImgUrl { get; set; }

        [Display(Name = "Ingredients")]
        public List<SelectListItem> Ingredients { get; set; }
        public List<SelectListItem> PossibleStepNumbers { get; set; } 
        public IList<AdminSelectedIngredient> SelectedIngredients { get; set; }
        
        [Display(Name = "Recipe Steps")]
        public IList<AdminRecipeStep> RecipeSteps { get; set; }

        //constuctor auto-populates the SelectListItem list
        public AdminCocktailsVM()
        {
            SelectedIngredients = new List<AdminSelectedIngredient>
            {
                new AdminSelectedIngredient()
            };
            RecipeSteps = new List<AdminRecipeStep>
            {
                new AdminRecipeStep()
            };

            Ingredients = new List<SelectListItem>();

            PossibleStepNumbers = new List<SelectListItem>();
            for (int i = 1; i < 11; i++)
            {
                PossibleStepNumbers.Add(new SelectListItem
                {
                    Text = i.ToString(),
                    Value = i.ToString()
                });
            }
        }

        public void Populate(List<Ingredient> ingredients)
        {
            Ingredients = ingredients.Select(m => new SelectListItem
            {
                Text = m.Name,
                Value = m.IngredientId.ToString()
            })
            .OrderBy(m => m.Text)
            .ToList();   
        }

        public void AddEmptyIngredient()
        {
            SelectedIngredients.Add(new AdminSelectedIngredient());
        }
    }
}