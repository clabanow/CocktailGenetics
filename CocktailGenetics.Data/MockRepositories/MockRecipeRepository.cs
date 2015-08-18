using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.MockRepositories
{
    public class MockRecipeRepository : IRecipeRespository
    {
        private List<Recipe> _mockList = new List<Recipe>
        {
            new Recipe
            {
                RecipeId = 2,
                CocktailId = 1,
                StepNumber = 2,
                Text = "Do another thing"
            },
            new Recipe
            {
                RecipeId = 4, 
                CocktailId = 4,
                StepNumber = 1,
                Text = "Empty the glass"
            }
        }; 

        public List<Models.Recipe> GetAllRecipes()
        {
            return _mockList;
        }

        public List<Models.Recipe> GetAllRecipeStepsByCocktail(int id)
        {
            return _mockList.Where(m => m.CocktailId == id).ToList();
        }

        public Models.Recipe GetRecipeById(int id)
        {
            return _mockList.Where(m => m.RecipeId == id).FirstOrDefault();
        }

        public Models.Recipe AddRecipe(Models.Recipe recipe)
        {
            return _mockList[0];
        }

        public Models.Recipe EditRecipe(Models.Recipe recipe)
        {
            return _mockList[0];
        }

        public void DeleteRecipe(int id)
        {
            throw new NotImplementedException();
        }
    }
}
