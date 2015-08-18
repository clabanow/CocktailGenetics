using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Angular
{
    public class RecipeAng
    {
        public string CocktailName { get; set; }
        public string ImgUrl { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> RecipeSteps { get; set; }

        public RecipeAng()
        {
            Ingredients = new List<string>();
            RecipeSteps = new List<string>();
        }


    }
}