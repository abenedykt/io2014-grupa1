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

namespace Interceptors
{
    public class ExecutionTime : IInterceptor
    {
        TextWriter _output;

        public ExecutionTime(TextWriter output)
        {
            _output = output;
        }

        public void Intercept(IInvocation invocation)
        {
            _output.WriteLine("sadsada");
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
            builder.RegisterType<InterceptorsController>()
                .As < IInterceptorsController>()
               .EnableInterfaceInterceptors();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
