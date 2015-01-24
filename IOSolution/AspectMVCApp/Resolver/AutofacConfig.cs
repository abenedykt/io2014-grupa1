using AspectMVCApp.Aspects;
using AspectMVCApp.Controllers;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.DynamicProxy;
using System.Diagnostics;

namespace AspectMVCApp.Resolver
{
    public static class AutofacConfig
    {
        public static void ConfigureAutofac(){

            var builder = new ContainerBuilder();
            builder.RegisterType<HomeController>().EnableClassInterceptors();

            builder.Register(c => new ExecutionTimer()).Named<IInterceptor>("timer");

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}