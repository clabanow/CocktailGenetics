using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.MockRepositories
{
    public class MockCocktailRepository : ICocktailRepository
    {
        private List<Cocktail> _mockList = new List<Cocktail>
        {
            new Cocktail
            {
                CocktailId = 1,
                Name = "Old Fashioned",
                ImgUrl = "link"
            },
            new Cocktail
            {
                CocktailId = 2,
                Name = "Mojito",
                ImgUrl = "other link"
            }
        }; 

        public List<Models.Cocktail> GetAllCocktails()
        {
            return _mockList;
        }

        public Models.Cocktail GetCocktailById(int id)
        {
            return _mockList[0];
        }

        public Models.Cocktail AddCocktail(Models.Cocktail cocktial)
        {
            return _mockList[0];
        }

        public Models.Cocktail EditCocktail(Models.Cocktail cocktail)
        {
            return _mockList[0];
        }

        public void DeleteCocktail(int id)
        {
            throw new NotImplementedException();
        }
    }
}
