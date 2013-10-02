using System;
using Nancy;
using NancyTest.Model;

namespace NancyTest
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = x =>
      {
        return "<html><head><title>Hello from Nancy!</title></head><body>Hello from Nancy!</body></html>";
      };

      Get["/product"] = _ =>
      {
        var product = new Product() { Name= "Sirlion Steak", Price = 14.99};

        return product;
      };

    }
  }
}
