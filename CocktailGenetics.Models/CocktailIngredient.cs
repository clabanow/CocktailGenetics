using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailGenetics.Models
{
    public class CocktailIngredient
    {
        public int CocktailIngredientId { get; set; }
        public int CocktailId { get; set; }
        public int IngredientId { get; set; }
        public string Amount { get; set; }
    }
}
