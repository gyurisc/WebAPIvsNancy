using Owin;

namespace NancyTest
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.UseNancy();
    }
  }
}
