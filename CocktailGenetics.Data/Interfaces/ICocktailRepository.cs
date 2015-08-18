using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailGenetics.Models;

namespace CocktailGenetics.Data.Interfaces
{
    public interface ICocktailRepository
    {
        List<Cocktail> GetAllCocktails();
        Cocktail GetCocktailById(int id);
        Cocktail AddCocktail(Cocktail cocktial);
        Cocktail EditCocktail(Cocktail cocktail);
        void DeleteCocktail(int id);
    }
}
