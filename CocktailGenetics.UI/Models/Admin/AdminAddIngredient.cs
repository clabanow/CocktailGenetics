using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CocktailGenetics.Models;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminAddIngredient
    {
        public int Id { get; set; }
        public List<SelectListItem> Ingredients { get; set; }

        public string NameIdTag {get {return "SelectedIngredients_" + Id + "__Id";}}
        public string NameNameTag { get { return "SelectedIngredients[" + Id + "].Id"; } }
        public string AmountIdTag { get { return "SelectedIngredients_" + Id + "__Amount"; } }
        public string AmountNameTag { get { return "SelectedIngredients[" + Id + "].Amount"; } }

        public AdminAddIngredient()
        {
            Ingredients = new List<SelectListItem>();
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
    }
}