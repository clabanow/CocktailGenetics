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
    public class CocktailIngredientSqlRepository : ICocktailIngredientRepository
    {
        public List<CocktailIngredient> GetAllCocktailIngredients()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                return
                    connection.Query<CocktailIngredient>("CocktailIngredientGetAll",
                        commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public CocktailIngredient GetCocktailIngredientById(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailIngredientId", id);

                return
                    connection.Query<CocktailIngredient>("CocktailIngredientGetById", p,
                        commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public CocktailIngredient AddCocktailIngredient(CocktailIngredient ci)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailId", ci.CocktailId);
                p.Add("IngredientId", ci.IngredientId);
                p.Add("Amount", ci.Amount);
                p.Add("CocktailIngredientId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("CocktailIngredientAdd", p, commandType: CommandType.StoredProcedure);
                ci.CocktailIngredientId = p.Get<int>("CocktailIngredientId");
                return ci;
            }
        }

        public CocktailIngredient EditCocktailIngredient(CocktailIngredient ci)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailId", ci.CocktailId);
                p.Add("IngredientId", ci.IngredientId);
                p.Add("Amount", ci.Amount);
                p.Add("CocktailIngredientId", ci.CocktailIngredientId);

                connection.Execute("CocktailIngredientAdd", p, commandType: CommandType.StoredProcedure);
                return ci;
            }
        }

        public void DeleteCocktailIngredient(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailIngredientId", id);

                connection.Execute("CocktailIngredientDelete", p, commandType: CommandType.StoredProcedure);
            }
        }


        public List<CocktailIngredient> GetAllIngredientsByCocktailId(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailId", id);

                return
                    connection.Query<CocktailIngredient>("CocktailIngredientIngredientIdGetAllByCocktailId", p,
                        commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
