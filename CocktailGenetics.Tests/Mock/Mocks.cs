using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Models;

namespace CocktailGenetics.Tests.Mock
{
    public static class Mocks
    {
        public static Recipe mockRecipe
        {
            get
            {
                return new Recipe
                {
                    RecipeId = 1,
                    CocktailId = 1,
                    StepNumber = 1,
                    Text = "hello"
                };
            }
        }

        public static Cocktail mockCocktail
        {
            get
            {
                return new Cocktail
                {
                    CocktailId = 1,
                    Name = "Tequila Shot",
                    RecipeLink = "link"
                };
            }
        }

        public static Ingredient mockIngredient
        {
            get
            {
                return new Ingredient
                {
                    IngredientId = 1,
                    IsLiquor = false,
                    Name = "Syrup"
                };
            }
        }

        public static CocktailIngredient MockCocktailIngredient
        {
            get
            {
                return new CocktailIngredient
                {
                    IngredientId = 3,
                    CocktailId = 5,
                    CocktailIngredientId = 2
                };
            }
        }

        
    }
}
