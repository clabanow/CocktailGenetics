using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminSelectedIngredient
    {
        [Required(ErrorMessage = "You must select an ingredient")]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter an amount")]
        public string Amount { get; set; }
    }
}