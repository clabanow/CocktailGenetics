using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;
using Dapper;

namespace CocktailGenetics.Data.SqlRepositories
{
    public class RecipeSqlRespository : IRecipeRespository
    {
        public List<Recipe> GetAllRecipes()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                return connection.Query<Recipe>("RecipeGetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<Recipe> GetAllRecipeStepsByCocktail(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@CocktailId", id);

                return
                    connection.Query<Recipe>("RecipeGetAllByCocktailId", p, commandType: CommandType.StoredProcedure)
                        .ToList();
            }
        }

        public Recipe GetRecipeById(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@RecipeId", id);

                return
                    connection.Query<Recipe>("RecipeGetById", p, commandType: CommandType.StoredProcedure)
                        .FirstOrDefault();
            }
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@CocktailId", recipe.CocktailId);
                p.Add("@StepNumber", recipe.StepNumber);
                p.Add("@Text", recipe.Text);
                p.Add("@RecipeId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("RecipeAdd", p, commandType: CommandType.StoredProcedure);

                recipe.RecipeId = p.Get<int>("@RecipeId");

                return recipe;
            }
        }

        public Recipe EditRecipe(Recipe recipe)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@CocktailId", recipe.CocktailId);
                p.Add("@RecipeId", recipe.RecipeId);
                p.Add("@StepNumber", recipe.StepNumber);
                p.Add("@Text", recipe.Text);

                connection.Execute("RecipeEdit", p, commandType: CommandType.StoredProcedure);

                return recipe;
            }
        }

        public void DeleteRecipe(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@RecipeId", id);

                connection.Execute("RecipeDelete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
