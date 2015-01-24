using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Castle.DynamicProxy;

namespace Timer.Controllers
{
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
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View(model: (DateTime.Now.Millisecond + DateTime.Now.Second).ToString());
        }
    }
}