using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Angular
{
    public class IndexAng
    {
        public List<IngredientAng> Ingredients { get; set; }
        public List<RecipeAng> Recipes { get; set; }

        public IndexAng()
        {
            Ingredients = new List<IngredientAng>();
            Recipes = new List<RecipeAng>();
        }
    }
}