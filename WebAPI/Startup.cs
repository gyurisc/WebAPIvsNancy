using System;
using System.Web.Http;
using Owin;

namespace WebAPI
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      var config = new HttpConfiguration();

      //Request Path Logger
      app.Use(typeof(RequestPathLogger));

      app.UseStaticFiles();

      // Configuring routes 
      config.Routes.MapHttpRoute(
          name: "Default",
          routeTemplate: "{controller}/{action}/{id}",
          defaults: new
          {
            controller = "Default",
            id = RouteParameter.Optional,
            action = RouteParameter.Optional
          });

      config.Routes.MapHttpRoute(
          name: "Product",
          routeTemplate: "Product/{action}/{id}",
          defaults: new
          {
            controller = "Product",
            id = RouteParameter.Optional,
            action = RouteParameter.Optional
          });

      //Configure Razor

      app.UseWebApi(config);
    }
  }
}
