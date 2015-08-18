using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Data.SqlRepositories;

namespace CocktailGenetics.Data
{
    public static class RepoFactory
    {
        private static ICocktailRepository _cocktailRepo;
        private static IIngredientRepository _ingredientRepo;
        private static ICocktailIngredientRepository _cocktailIngredientRepo;
        private static IRecipeRespository _recipeRepo;
        private static string _mode;

        private static string GetMode()
        {
            if (string.IsNullOrEmpty(_mode))
            {
                _mode = ConfigurationManager.AppSettings["Mode"];
            }
            return _mode;
        }

        public static IRecipeRespository GetRecipeRepo()
        {
            if (_recipeRepo == null)
            {
                if (GetMode() != "Mock")
                {
                    _recipeRepo = new RecipeSqlRespository();
                }
                //otherwise get another repo based on the mode
            }
            return _recipeRepo;
        }

        public static ICocktailRepository GetCocktailRepo()
        {
            if (_cocktailRepo == null)
            {
                if (GetMode() != "Mock")
                {
                    _cocktailRepo = new CocktailSqlRepository();
                }
                //otherwise get a different repo
            }
            return _cocktailRepo;
        }

        public static IIngredientRepository GetIngredientRepository()
        {
            if (_ingredientRepo == null)
            {
                if (GetMode() != "Mock")
                {
                    _ingredientRepo = new IngredientSqlRepository();
                }
                //otherwise get a different repo
            }
            return _ingredientRepo;
        }

        public static ICocktailIngredientRepository GetCocktailIngredientRepo()
        {
            if (_cocktailIngredientRepo == null)
            {
                if (GetMode() != "Mock")
                {
                    _cocktailIngredientRepo = new CocktailIngredientSqlRepository();
                }
            }
            return _cocktailIngredientRepo;
        }

    }
}
