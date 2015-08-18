using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;
using Dapper;

namespace CocktailGenetics.Data.SqlRepositories
{
    public class CocktailSqlRepository : ICocktailRepository
    {
        public List<Cocktail> GetAllCocktails()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                return connection.Query<Cocktail>("CocktailGetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public Cocktail GetCocktailById(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailId", id);

                return
                    connection.Query<Cocktail>("CocktailGetById", p, commandType: CommandType.StoredProcedure)
                        .FirstOrDefault();
            }
        }

        public Cocktail AddCocktail(Cocktail cocktial)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("Name", cocktial.Name);
                p.Add("ImgUrl", cocktial.ImgUrl);
                p.Add("CocktailId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("CocktailAdd", p, commandType: CommandType.StoredProcedure);

                cocktial.CocktailId = p.Get<int>("CocktailId");
            }
            return cocktial;
        }

        public Cocktail EditCocktail(Cocktail cocktail)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailId", cocktail.CocktailId);
                p.Add("Name", cocktail.Name);
                p.Add("ImgUrl", cocktail.ImgUrl);

                connection.Execute("CocktailEdit", p, commandType: CommandType.StoredProcedure);

                return cocktail;
            }
        }

        public void DeleteCocktail(int id)
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("CocktailId", id);

                connection.Execute("CocktailDelete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
