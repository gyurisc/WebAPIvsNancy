using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Model;
using Newtonsoft.Json.Linq;

namespace WebAPI.Controllers
{
  public class ProductController : ApiController
  {
    [HttpGet]
    public HttpResponseMessage Index()
    {
      var product = new Product() { Name = "Sirlion Steak", Price = 14.99 };
      var response = new HttpResponseMessage(HttpStatusCode.OK);
      var content = new RazorView("WebAPI.Views.Product.cshtml", product).Run();
      response.Content = new StringContent(content, System.Text.Encoding.UTF8, "text/html");

      return response;
    }
  }
}
