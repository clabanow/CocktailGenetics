using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailGenetics.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public int CocktailId { get; set; }
        public int StepNumber { get; set; }
        public string Text { get; set; }
    }
}
