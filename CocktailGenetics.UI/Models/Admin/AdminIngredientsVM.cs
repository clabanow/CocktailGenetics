using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminIngredientsVM
    {
        public IList<AdminIngredient> SelectedIngredients { get; set; }
        public IList<SelectListItem> YesNoChoices { get; set; }

        public AdminIngredientsVM()
        {
            SelectedIngredients = new List<AdminIngredient>
            {
                new AdminIngredient()
            };

            YesNoChoices = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Yes",
                    Value = true.ToString()
                },
                new SelectListItem
                {
                    Text = "No",
                    Value = false.ToString()
                }
            };
        }
    }
}