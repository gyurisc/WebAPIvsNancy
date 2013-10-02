using System;
using System.IO;
using System.Reflection;
using System.Web.Http;
using Owin;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;

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

      app.UseWebApi(config);

      //Configure Razor
      var viewPathTemplate = "{0}";
      var templateConfig = new TemplateServiceConfiguration();
      templateConfig.Resolver = new DelegateTemplateResolver(name =>
      {
        var resourcePath = string.Format(viewPathTemplate, name);

        var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
        if (stream == null)
          stream = Assembly.GetAssembly(typeof(WebAPI.RazorView)).GetManifestResourceStream(name);

        using (var reader = new StreamReader(stream))
        {
          return reader.ReadToEnd();
        }
      });

      Razor.SetTemplateService(new TemplateService(templateConfig));

    }
  }
}
