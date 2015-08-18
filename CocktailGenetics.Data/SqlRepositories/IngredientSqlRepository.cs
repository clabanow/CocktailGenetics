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
    public class IngredientSqlRepository : IIngredientRepository
    {
        public List<Ingredient> GetAllIngredients()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                return
                    connection.Query<Ingredient>("IngredientGetAll",
                        commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public Ingredient GetIngredientById(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("IngredientId", id);

                return
                    connection.Query<Ingredient>("IngredientGetById", p,
                        commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public Ingredient AddIngredient(Ingredient ingredient)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("Name", ingredient.Name);
                p.Add("IsLiquor", ingredient.IsLiquor);
                p.Add("IngredientId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("IngredientAdd", p, commandType: CommandType.StoredProcedure);
                ingredient.IngredientId = p.Get<int>("IngredientId");
                return ingredient;
            }
        }

        public Ingredient EditIngredient(Ingredient ingredient)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("IngredientId", ingredient.IngredientId);
                p.Add("Name", ingredient.Name);
                p.Add("IsLiquor", ingredient.IsLiquor);

                connection.Execute("IngredientEdit", p, commandType: CommandType.StoredProcedure);
                return ingredient;
            }
        }

        public void DeleteIngredient(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("IngredientId", id);

                connection.Execute("IngredientDelete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
