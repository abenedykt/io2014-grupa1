using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Diagnostics;
using Castle.DynamicProxy;
using System.IO;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Sekunda/

        public ViewResult Index()
        {
            System.Threading.Thread.Sleep(2000);
            
            return View(model: (DateTime.Now.Second + DateTime.Now.Millisecond).ToString());
        }

    }
}
