using Autofac;
using Autofac.Integration.Mvc;
using Castle.DynamicProxy;
using Interceptors.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac.Extras.DynamicProxy2;
using System.Diagnostics;

namespace Interceptors
{
    public class ExecutionTime : IInterceptor
    {


        public void Intercept(IInvocation invocation)
        {
            var start = DateTime.UtcNow;
            invocation.Proceed();
            var stop = DateTime.UtcNow;
            Debug.WriteLine("Metode wykonano w {0} ms.",(start-stop).TotalMilliseconds);
        }
    }

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.Register(c => new ExecutionTime());
            builder.RegisterType<InterceptorsController>().EnableClassInterceptors();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
