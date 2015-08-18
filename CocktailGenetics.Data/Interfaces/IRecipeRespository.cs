using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.Interfaces
{
    public interface IRecipeRespository
    {
        List<Recipe> GetAllRecipes();
        List<Recipe> GetAllRecipeStepsByCocktail(int id);
        Recipe GetRecipeById(int id);
        Recipe AddRecipe(Recipe recipe);
        Recipe EditRecipe(Recipe recipe);
        void DeleteRecipe(int id);
    }
}
