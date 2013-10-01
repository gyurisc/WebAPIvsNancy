using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Model;

namespace WebAPI.Controllers
{
  public class ProductController : ApiController
  {
    [HttpGet]
    public Product Index()
    {
      var product = new Product() { Name = "Sirlion Steak", Price = 14.99 };

      return product;
    }
  }
}
