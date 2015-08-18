using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using CocktailGenetics.Data;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Data.SqlRepositories;
using CocktailGenetics.Models;
using CocktailGenetics.Tests.Mock;
using Dapper;
using NUnit.Framework;

namespace CocktailGenetics.Tests
{
    [TestFixture]
    public class CocktailRepoTests
    {
        private ICocktailRepository _cocktailRepo = RepoFactory.GetCocktailRepo();

        [SetUp]
        public void Setup()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                connection.Execute("DbReset", commandType: CommandType.StoredProcedure);
            }
        }

        [Test]
        public void CanGetAllCocktails()
        {
            var cocktails = _cocktailRepo.GetAllCocktails();
            Assert.AreEqual(cocktails.Count, 6);
            Assert.AreEqual(cocktails.First().Name, "Cuba Libre");
        }

        [Test]
        public void CanGetCocktailById()
        {
            var cocktail = _cocktailRepo.GetCocktailById(1);
            Assert.AreEqual(cocktail.Name, "Cuba Libre");
        }

        [Test]
        public void CanAddCocktail()
        {
            var addedCocktail = _cocktailRepo.AddCocktail(Mocks.mockCocktail);
            Assert.AreEqual(_cocktailRepo.GetAllCocktails().Count, 7);
            Assert.AreEqual(addedCocktail.CocktailId, 7);
        }

        [Test]
        public void CanEditCocktail()
        {
            _cocktailRepo.EditCocktail(Mocks.mockCocktail);
            var result = _cocktailRepo.GetCocktailById(1).Name;
            Assert.AreEqual(result, Mocks.mockCocktail.Name);
        }

        [Test]
        public void CanDeleteCocktail()
        {
            var beforeCount = _cocktailRepo.GetAllCocktails().Count;
            _cocktailRepo.DeleteCocktail(1);
            var afterCount = _cocktailRepo.GetAllCocktails().Count;
            Assert.AreEqual(beforeCount, afterCount + 1);
        }
    }
}
