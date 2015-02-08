using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interceptors.Controllers
{
    [Intercept(typeof(ExecutionTime))]
    public class InterceptorsController : Controller
    {
        // GET: Interceptors
        public string Index()
        {

            return DateTime.UtcNow.ToString();
        }
    }
}