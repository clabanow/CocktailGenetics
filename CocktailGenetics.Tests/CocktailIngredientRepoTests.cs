using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Data;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Tests.Mock;
using Dapper;
using NUnit.Framework;

namespace CocktailGenetics.Tests
{
    [TestFixture]
    public class CocktailIngredientRepoTests
    {
        private ICocktailIngredientRepository _repo = RepoFactory.GetCocktailIngredientRepo();

        [SetUp]
        public void Setup()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                connection.Execute("DbReset", commandType: CommandType.StoredProcedure);
            }
        }

        [Test]
        public void CanGetAllCocktailIngredients()
        {
            var ci = _repo.GetAllCocktailIngredients();
            Assert.AreEqual(ci.Count, 20);
        }

        [Test]
        public void CanGetCocktailIngredientById()
        {
            var ci = _repo.GetCocktailIngredientById(1);
            Assert.AreEqual(ci.IngredientId, 1);
        }

        [Test]
        public void CanAddCocktailIngredient()
        {
            _repo.AddCocktailIngredient(Mocks.MockCocktailIngredient);
            Assert.AreEqual(_repo.GetAllCocktailIngredients().Count, 21);
        }

        [Test]
        public void CanEditCocktailIngredient()
        {
            _repo.EditCocktailIngredient(Mocks.MockCocktailIngredient);
            Assert.AreEqual(_repo.GetCocktailIngredientById
                (Mocks.MockCocktailIngredient.CocktailIngredientId).CocktailId, 
                 Mocks.mockCocktail.CocktailId);
        }

        [Test]
        public void CanDeleteCocktailIngredient()
        {
            var before = _repo.GetAllCocktailIngredients().Count;
            _repo.DeleteCocktailIngredient(1);
            var after = _repo.GetAllCocktailIngredients().Count;
            Assert.AreEqual(before, after + 1);
        }
    }
}
