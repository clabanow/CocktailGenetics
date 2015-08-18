using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.Interfaces
{
    public interface ICocktailIngredientRepository
    {
        List<CocktailIngredient> GetAllCocktailIngredients();
        CocktailIngredient GetCocktailIngredientById(int id);
        CocktailIngredient AddCocktailIngredient(CocktailIngredient ci);
        CocktailIngredient EditCocktailIngredient(CocktailIngredient ci);
        void DeleteCocktailIngredient(int id);
        List<CocktailIngredient> GetAllIngredientsByCocktailId(int id);
    }
}
