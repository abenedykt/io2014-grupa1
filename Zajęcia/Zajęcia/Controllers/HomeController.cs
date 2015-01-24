using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zajęcia.Controllers
{
    [Intercept(typeof(CallLogger))]
    public class HomeController : Controller
    {
        //
        // GET: /Sekunda/

        public ViewResult Index()
        {
            return View(model: DateTime.Now.Millisecond.ToString());
        }

    }
}
