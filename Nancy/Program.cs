using System;
using Microsoft.Owin.Hosting;

namespace NancyTest
{
  class Program
  {
    static void Main(string[] args)
    {
      var url = "http://localhost:7844";

      using (WebApp.Start<Startup>(url))
      {
        Console.WriteLine("Running on http://localhost:7844", url);
        Console.WriteLine("Press enter to exit");
        Console.ReadLine();
      }
    }
  }
}
