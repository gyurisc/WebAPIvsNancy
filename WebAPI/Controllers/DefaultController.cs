using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
  public class DefaultController : ApiController
  {
    [HttpGet]
    public HttpResponseMessage Index()
    {
      var content = "<html><head><title>Hello from WebApi!</title></head><body>Hello from WebApi! Designed By Csabi!TM</body></html>";
      var response = new HttpResponseMessage(HttpStatusCode.OK);
      response.Content = new StringContent(content, System.Text.Encoding.UTF8, "text/html");

      return response;
    }
  }
}
