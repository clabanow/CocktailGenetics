using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CocktailGenetics.Data;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Tests.Mock;
using Dapper;
using NUnit.Framework;

namespace CocktailGenetics.Tests
{
    [TestFixture]
    class RecipeRepoTests
    {
        private IRecipeRespository repo = RepoFactory.GetRecipeRepo();

        [SetUp]
        public void Setup()
        {
            using (var connection = new SqlConnection(Settings.GetConnectionString()))
            {
                connection.Execute("DbReset", commandType: CommandType.StoredProcedure);
            }
        }

        [Test]
        public void CanGetAllRecipes()
        {
            var recipes = repo.GetAllRecipes();
            Assert.AreEqual(recipes.Count, 18);
        }

        [Test]
        public void CanGetAllRecipesPerCocktail()
        {
            var recipes = repo.GetAllRecipeStepsByCocktail(1);
            Assert.AreEqual(recipes.Count, 4);
        }

        [Test]
        public void GetRecipeById()
        {
            var recipe = repo.GetRecipeById(2);
            Assert.AreEqual(recipe.Text, "Add ice cubes");
        }

        [Test]
        public void CanAddRecipe()
        {
            repo.AddRecipe(Mock.Mocks.mockRecipe);
            var count = repo.GetAllRecipes().Count;
            Assert.AreEqual(count, 19);
        }

        [Test]
        public void CanEditRecipe()
        {
            repo.EditRecipe(Mocks.mockRecipe);
            Assert.AreEqual(repo.GetRecipeById(Mocks.mockRecipe.RecipeId).Text, Mocks.mockRecipe.Text);
        }

        [Test]
        public void CanDeleteRecipe()
        {
            var beforeCount = repo.GetAllRecipes().Count;
            repo.DeleteRecipe(1);
            var afterCount = repo.GetAllRecipes().Count;
            Assert.AreEqual(beforeCount - 1, afterCount);
        }
    }
}
