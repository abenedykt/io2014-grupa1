using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interceptors.Controllers
{
    public interface IInterceptorsController
    {
        string Index();

    }
    public class InterceptorsController : Controller, IInterceptorsController
    {
        // GET: Interceptors
        [Intercept(typeof(ExecutionTime))]

        public string Index()
        {

            return DateTime.UtcNow.ToString();
        }
    }
}