using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Angular
{
    public class UserSelectionAng
    {
        public List<IngredientAng> SelectedIngredients { get; set; }
        public bool OnlyTheseIngredients { get; set; }
    }
}