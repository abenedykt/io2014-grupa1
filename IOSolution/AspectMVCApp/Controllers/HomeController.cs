using Autofac.Extras.DynamicProxy2;
using System;
using System.Threading;
using System.Web.Mvc;

namespace AspectMVCApp.Controllers
{
    [Intercept("timer")]
    public class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            Thread.Sleep(5000);
            var model = (DateTime.Now.Millisecond + DateTime.Now.Second).ToString();
            return View(model: model);
        }
    }
}