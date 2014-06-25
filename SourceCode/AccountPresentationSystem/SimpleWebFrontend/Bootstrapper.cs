using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using SimpleWebFrontend.Repositories;

namespace SimpleWebFrontend
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            if (Properties.Settings.Default.UseFakeRepos)
            {
                container.RegisterType<IStatementRepository, FakeStatementRepository>();
            }
            else
            {
                container.RegisterType<IStatementRepository, StatementRepository>();
            }

            return container;
        }
    }
}