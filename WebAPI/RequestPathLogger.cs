using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace WebAPI
{
  public class RequestPathLogger
  {
    private readonly AppFunc _next;
    public RequestPathLogger(AppFunc next)
    {
      if (next == null)
      {
        throw new ArgumentNullException("next");
      }
      _next = next;
    }
    public Task Invoke(IDictionary<string, object> environment)
    {
      Console.WriteLine(string.Format("Hitting TestLogger, path: {0}", environment["owin.RequestPath"]));
      return _next(environment);
    }
  }
}
