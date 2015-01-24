﻿using Aspekty.Controllers;
using Aspekty.Models;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aspekty
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();
            builder
                .RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<HomeController>().EnableClassInterceptors();
            builder.Register(c => new MethodExecutionTime());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}