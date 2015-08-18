using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.MockRepositories
{
    public class MockIngredientRepository : IIngredientRepository
    {
        private List<Ingredient> _mockList = new List<Ingredient>
        {
            new Ingredient
            {
                IngredientId = 1,
                Name = "Gin",
                IsLiquor = true
            },
            new Ingredient
            {
                IngredientId = 2,
                Name = "Whiskey",
                IsLiquor = true
            }
        }; 

        public List<Models.Ingredient> GetAllIngredients()
        {
            return _mockList;
        }

        public Models.Ingredient GetIngredientById(int id)
        {
            return _mockList[0];
        }

        public Models.Ingredient AddIngredient(Models.Ingredient ingredient)
        {
            return _mockList[0];
        }

        public Models.Ingredient EditIngredient(Models.Ingredient ingredient)
        {
            return _mockList[0];
        }

        public void DeleteIngredient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
