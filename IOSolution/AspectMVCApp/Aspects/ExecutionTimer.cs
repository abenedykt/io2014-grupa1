using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.DynamicProxy;
using System.Diagnostics;
using System.IO;

namespace AspectMVCApp.Aspects
{
    public class ExecutionTimer : IInterceptor
    {
        private Stopwatch _watch;

        public ExecutionTimer()
        {
            this._watch = new Stopwatch();
        }

        public void Intercept(IInvocation invocation)
        {
            this._watch.Start();

            invocation.Proceed();

            this._watch.Stop();
            Debug.WriteLine(this._watch.Elapsed.ToString());
        }
    }
}