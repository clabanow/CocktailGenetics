using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Result
{
    public class ResultGetResultsCocktails
    {
        public string Name { get; set; }
        public string RecipeLink { get; set; }
        public List<string> Ingredients { get; set; }

        public ResultGetResultsCocktails()
        {
            Ingredients = new List<string>();
        }
    }
}