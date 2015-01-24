using Castle.DynamicProxy;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Timers;

namespace Aspekty.Interceptors
{
    public class TimerLogger : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            invocation.Proceed();

            watch.Stop();

            Debug.WriteLine(watch.Elapsed.ToString());
        }
    }
}