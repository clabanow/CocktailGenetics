using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
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
    public class IngredientRepoTests
    {
        private IIngredientRepository _repo = RepoFactory.GetIngredientRepository();

        [SetUp]
        public void Setup()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                connection.Execute("DbReset", commandType: CommandType.StoredProcedure);
            }
        }

        [Test]
        public void CanGetAllIngredients()
        {
            var ingredients = _repo.GetAllIngredients();
            Assert.AreEqual(ingredients.Count, 15);
        }

        [Test]
        public void CanGetIngredientById()
        {
            var ingredient = _repo.GetIngredientById(1);
            Assert.AreEqual(ingredient.Name, "Coca Cola");
        }

        [Test]
        public void CanAddIngredient()
        {
            _repo.AddIngredient(Mocks.mockIngredient);
            Assert.AreEqual(_repo.GetAllIngredients().Count, 16);
        }

        [Test]
        public void CanEditIngredient()
        {
            _repo.EditIngredient(Mocks.mockIngredient);
            var editedIngredientName = _repo.GetIngredientById
                (Mocks.mockIngredient.IngredientId).Name;
            Assert.AreEqual(editedIngredientName, Mocks.mockIngredient.Name);
        }

        [Test]
        public void CanDeleteIngredient()
        {
            var before = _repo.GetAllIngredients().Count;
            _repo.DeleteIngredient(1);
            var after = _repo.GetAllIngredients().Count;
            Assert.AreEqual(before, after + 1);
        }
    }
}
