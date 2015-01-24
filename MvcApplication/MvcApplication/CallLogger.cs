using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Diagnostics;
using Castle.DynamicProxy;
using System.IO;

namespace MvcApplication
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
}