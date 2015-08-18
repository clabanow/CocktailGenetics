using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CocktailGenetics.Data.Interfaces;
using CocktailGenetics.Data.SqlRepositories;
using Ninject;

namespace CocktailGenetics.UI.Infra
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<ICocktailRepository>().To<CocktailSqlRepository>();
            ninjectKernel.Bind<IIngredientRepository>().To<IngredientSqlRepository>();
            ninjectKernel.Bind<ICocktailIngredientRepository>().To<CocktailIngredientSqlRepository>();
            ninjectKernel.Bind<IRecipeRespository>().To<RecipeSqlRespository>();
        }
    }
}