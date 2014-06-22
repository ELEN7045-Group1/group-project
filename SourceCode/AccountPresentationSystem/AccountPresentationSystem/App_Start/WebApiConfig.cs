using AccountPresentationSystem.Domain.Model.Scheduling;
using AccountPresentationSystem.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AccountPresentationSystem.App_Start
{
    public static class Bootstrapper
    {
        public static void Setup(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            // Unity Dependency Injection
            var container = new UnityContainer();
            IDBConnection databaseConnection = new DBConnection();

            container.RegisterInstance<IDBConnection>(databaseConnection);
            //container.RegisterType<IDBConnection, DBConnection>();
            container.RegisterType<IScheduleRepository, ScheduleRepository>();

            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
