using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Home
{
    public class HomeIndexViewModel
    {
        public List<HomeIndexIngredient> Ingredients { get; set; }

        public HomeIndexViewModel()
        {
            Ingredients = new List<HomeIndexIngredient>();
        }
    }
}