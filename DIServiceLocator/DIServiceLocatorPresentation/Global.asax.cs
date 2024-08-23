using DIServiceLocatorInfrastructure.Implementations;
using DIServiceLocatorInfrastructure.Interfaces;
using DIServiceLocatorPresentation.App_Start;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DIServiceLocatorPresentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            DependencyResolver.SetResolver(new ServiceProviderDependencyResolver(ServiceProvider));
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISampleService, SampleService>();
        }
    }
}
