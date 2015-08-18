using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.MockRepositories
{
    public class MockCocktailIngredientRepository : ICocktailIngredientRepository
    {
        private List<CocktailIngredient> _mockList = new List<CocktailIngredient>
        {
            new CocktailIngredient
            {
                IngredientId = 1,
                CocktailId = 1,
                CocktailIngredientId = 1,
                Amount = "1 oz"
            },
            new CocktailIngredient
            {
                IngredientId = 2, 
                CocktailId = 2,
                CocktailIngredientId = 2,
                Amount = "2 oz"
            }
        }; 

        public List<Models.CocktailIngredient> GetAllCocktailIngredients()
        {
            return _mockList;
        }

        public Models.CocktailIngredient GetCocktailIngredientById(int id)
        {
            return _mockList[0];
        }

        public Models.CocktailIngredient AddCocktailIngredient(Models.CocktailIngredient ci)
        {
            return _mockList[0];
        }

        public Models.CocktailIngredient EditCocktailIngredient(Models.CocktailIngredient ci)
        {
            return _mockList[0];
        }

        public void DeleteCocktailIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public List<CocktailIngredient> GetAllIngredientsByCocktailId(int id)
        {
            return _mockList;
        }
    }
}
