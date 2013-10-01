using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace WebAPI
{
  public class StaticServer
  {
    private readonly AppFunc _next;
    public StaticServer(AppFunc next)
    {
      if (next == null)
      {
        throw new ArgumentNullException("next");
      }
      _next = next;
    }

    //public Task Invoke(IDictionary<string, object> environment)
    //{
    //  try
    //  {
    //    var requestPath = (string)environment["owin.RequestPath"];
    //    if (requestPath.ToLower().StartsWith("/content/")||
    //      requestPath.ToLower().StartsWith("/scripts/") ||
    //      requestPath.ToLower().StartsWith("/views/widgets/") ||
    //      (requestPath.ToLower().StartsWith("/views/") && requestPath.ToLower().EndsWith(".html")) ||
    //      requestPath.ToLower().StartsWith("/assets/"))
    //    {
    //      var exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    //      var contentpath = exeFolder + requestPath.Replace("/","\\");
    //      if (File.Exists(contentpath))
    //      {
    //        var contentStream = System.IO.File.OpenRead(contentpath);
    //        var responseBytes = new byte[contentStream.Length];
    //        contentStream.Read(responseBytes, 0, responseBytes.Length); 

    //        var responseStream = (Stream)environment["owin.ResponseBody"];
    //        var responseHeaders =
    //            (IDictionary<string, string[]>)environment["owin.ResponseHeaders"];
    //        responseHeaders["Content-Length"] = new string[] { responseBytes.Length.ToString(CultureInfo.InvariantCulture) };

    //        if (contentpath.ToLower().Contains(".css"))
    //        {
    //          responseHeaders["Content-Type"] = new string[] { "text/css" };
    //        }
    //        else if (contentpath.ToLower().Contains(".js"))
    //        {
    //          responseHeaders["Content-Type"] = new string[] { "text/javascript" };
    //        }
    //        else if (contentpath.ToLower().Contains(".woff"))
    //        {
    //          responseHeaders["Content-Type"] = new string[] { "application/font-woff" };
    //        }
    //        else if (contentpath.ToLower().Contains(".ttf"))
    //        {
    //          responseHeaders["Content-Type"] = new string[] { "font/ttf" };
    //        }
    //        else if (contentpath.ToLower().Contains(".otf"))
    //        {
    //          responseHeaders["Content-Type"] = new string[] { "font/otf" };
    //        }
    //        else if (contentpath.ToLower().Contains(".svg"))
    //        {
    //          responseHeaders["Content-Type"] = new string[] { "image/svg+xml" };
    //        }
    //        else
    //        {
    //          responseHeaders["Content-Type"] = new string[] { "text/html" };
    //        }
            
    //        return responseStream.WriteAsync(responseBytes, 0, responseBytes.Length);
    //      }
    //    }
    //  }
    //  catch(Exception ex)
    //  {
    //    Console.WriteLine(ex.Message);
    //  }

    //  return _next(environment);
    //}
  }
}
