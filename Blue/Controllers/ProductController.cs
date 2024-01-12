using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Blue.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("/Products")]
    public class ProductController : ControllerBase
    {
        private ProductService productService;
        public ProductController()
        {
            productService = new ProductService();
        }

        [HttpGet("GetProducts")]
        [MapToApiVersion("1.0")]
        public List<Product> GetAuthorsNew()
        {
            return productService.ReadAll();
        }
    }
}