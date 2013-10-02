using System;
using Microsoft.Owin.Hosting;

namespace NancyTest
{
  class Program
  {
    static void Main(string[] args)
    {
      var url = "http://localhost:7843";

      using (WebApp.Start<Startup>(url))
      {
        Console.WriteLine(string.Format("Running on {0}", url));
        Console.WriteLine("Press enter to exit");
        Console.ReadLine();
      }
    }
  }
}
