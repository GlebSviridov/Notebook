using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyNoteebook.BLL.Util;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;

namespace MyNotebook.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

#pragma warning disable CS0436 // Type conflicts with imported type
            NinjectModule registrations = new NinjectRegistrations();
#pragma warning restore CS0436 // Type conflicts with imported type
            var kernel = new StandardKernel(registrations);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
