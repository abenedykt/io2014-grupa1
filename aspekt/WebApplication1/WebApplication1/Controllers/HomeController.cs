using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public class CallLogger : IInterceptor
        {
            TextWriter _output;

            public CallLogger(TextWriter output)
            {
                _output = output;
            }

            public void Intercept(IInvocation invocation)
            {
                _output.Write("Calling method {0} with parameters {1}... ",
                  invocation.Method.Name,
                  string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

                invocation.Proceed();

                _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);
            }
        }

        public ViewResult About()
        {
            System.Threading.Thread.Sleep(2000);
            return View( model: DateTime.Now.Millisecond.ToString() );
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}