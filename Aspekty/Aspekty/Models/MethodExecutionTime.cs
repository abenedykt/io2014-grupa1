using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace Aspekty.Models
{
    public class MethodExecutionTime : IInterceptor
    {

     
        public void Intercept(IInvocation invocation)
        {
            var now = DateTime.Now;
            invocation.Proceed();
            var etime = DateTime.Now - now;
            Debug.WriteLine(string.Format("Exe time: {0}", etime.ToString()));
        }
    }
}