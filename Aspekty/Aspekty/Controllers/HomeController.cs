using Aspekty.Interceptors;
using Aspekty.ViewModels;
using Autofac.Extras.DynamicProxy2;
using System;
using System.Diagnostics;
using System.Threading;
using System.Web.Mvc;

namespace Aspekty.Controllers
{
    [Intercept(typeof(TimerLogger))]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();

            viewModel.Prop = (DateTime.Now.Second + DateTime.Now.Millisecond).ToString();

            Thread.Sleep(2000);

            return View(viewModel);
        }
    }
}