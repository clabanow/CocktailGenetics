using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminIngredient
    {
        [Required(ErrorMessage = "You must enter a name")]
        public string Name { get; set; }
        public bool IsLiquor { get; set; }
    }
}