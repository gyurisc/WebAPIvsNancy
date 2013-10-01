using System;
using Nancy;

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
    }
  }
}
