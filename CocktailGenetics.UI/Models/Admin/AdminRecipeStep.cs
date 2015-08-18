using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminRecipeStep
    {
        [Required(ErrorMessage = "You must enter a step number")]
        public int RecipeStepNumber { get; set; }

        [Required(ErrorMessage = "You must describe the step")]
        public string Text { get; set; }
    }
}