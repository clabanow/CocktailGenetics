using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocktailGenetics.UI.Models.Admin
{
    public class AdminAddRecipeStep
    {
        public int Id { get; set; }
        public string StepNumberId { get { return "RecipeSteps_" + Id + "__RecipeStepNumber"; } }
        public string StepNumberName { get { return "RecipeSteps[" + Id + "].RecipeStepNumber"; } }
        public string DescriptionId { get { return "RecipeSteps_" + Id + "__Text"; } }
        public string DescriptionName { get { return "RecipeSteps[" + Id + "].Text"; } }
    }
}