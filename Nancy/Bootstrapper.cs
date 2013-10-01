using System;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.Diagnostics;
using Nancy.TinyIoc;

namespace NancyTest
{
  public class Bootstrapper : DefaultNancyBootstrapper
  {
    protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
    {
      base.ApplicationStartup(container, pipelines);
      this.Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Styles"));
    }

    protected override DiagnosticsConfiguration DiagnosticsConfiguration
    {
      get { return new DiagnosticsConfiguration { Password = @"Qwert12!" }; }
    }
  }
}
