using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminAddNewIngredient
    {
        public int Id { get; set; }
        public string NameIdTag { get { return "SelectedIngredients_" + Id + "__Name"; } }
        public string NameNameTag { get { return "SelectedIngredients[" + Id + "].Name"; } }
        public string IsLiquorIdTag { get { return "SelectedIngredients_" + Id + "__IsLiquor"; } }
        public string IsLiquorNameTag { get { return "SelectedIngredients[" + Id + "].IsLiquor"; } }
    }
}