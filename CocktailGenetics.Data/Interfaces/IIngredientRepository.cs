using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.Interfaces
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetAllIngredients();
        Ingredient GetIngredientById(int id);
        Ingredient AddIngredient(Ingredient ingredient);
        Ingredient EditIngredient(Ingredient ingredient);
        void DeleteIngredient(int id);
    }
}
