using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using VocabBuilder.DataModel.Sql;
using VocabBuilder.Model.Interfaces;

namespace VocabBuilder.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegiesterDependencyResolver();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void RegiesterDependencyResolver()
        {
            var kernel = new StandardKernel();
            RegisterServices(kernel);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }

        private void RegisterServices(StandardKernel kernel)
        {
            kernel.Bind<IWordRepo>().To<WordRepo>();
        }
    }
}
