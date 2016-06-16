using Business.Services;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWork;
using DataAccess;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using DataContext;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace EmptyWebApi.Infrastructure
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            RegisterDataAccess(container);
            RegisterServices(container);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void RegisterDataAccess(UnityContainer container)
        {
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>), new PerRequestLifetimeManager());
            container.RegisterType<IAppDataContext, AppDataContext>(new PerRequestLifetimeManager());
            container.RegisterType<IAppUnitOfWork, AppUnitOfWork>(new PerRequestLifetimeManager());
        }

        private static void RegisterServices(UnityContainer container)
        {
            container.RegisterType<ICountryService, CountryService>(new PerRequestLifetimeManager());
        }
    }
}