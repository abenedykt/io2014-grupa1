using Aspekty.Models;
using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspekty.Controllers
{
    [RoutePrefix("Home")]
    [Intercept(typeof(MethodExecutionTime))]
    public class HomeController : Controller
    {
        [Route("")]
        public string Index()
        {
            return DateTime.Now.ToString();
        }
    }
}