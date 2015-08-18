using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Result
{
    public class ResultGetResultsViewModel
    {
        public List<ResultGetResultsCocktails> Cocktails { get; set; }

        public ResultGetResultsViewModel()
        {
            Cocktails = new List<ResultGetResultsCocktails>();
        }
    }
}