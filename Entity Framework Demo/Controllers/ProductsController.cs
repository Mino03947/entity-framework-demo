using Microsoft.AspNetCore.Mvc;

namespace Entity_Framework_Demo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{

    // GET: api/products
    [HttpGet]
    public List<String> GetProducts()
    {
        return [];
    }
}
