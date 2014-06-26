using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using SimpleWebFrontend.Repositories;
using SimpleWebFrontend.App_Start;

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
                FakeData.InitFakeData();
                container.RegisterType<IStatementRepository, FakeStatementRepository>();
                container.RegisterType<IAccountRepository, FakeAccountRepository>();
                container.RegisterType<IBillingAccountsRepository, FakeBillingAccountsRepository>();
            }
            else
            {
                container.RegisterType<IStatementRepository, StatementRepository>();
            }

            return container;
        }
    }
}