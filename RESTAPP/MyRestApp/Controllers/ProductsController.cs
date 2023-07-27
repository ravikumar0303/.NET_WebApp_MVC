using Microsoft.AspNetCore.Mvc;
using BOL;
using MyRestApp.Services;
using SAL;
namespace MyRestApp.Controllers;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{
    private readonly MyRestApp.Services.IProductService _productService;

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger, MyRestApp.Services.IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet("/")]
    public JsonResult GetAll(){
        return new JsonResult(_productService.GetAll());
    }

    [HttpGet("/{id}")]
    public JsonResult GetById(int id){
        return new JsonResult(_productService.GetById(id));
    }

    [HttpPost("/")]
    public JsonResult AddProduct(Product product){
        return new JsonResult(_productService.AddProduct(product));
    }

    [HttpPut("/{id}")]
    public JsonResult UpdateProduct(int id, Product product){
        return new JsonResult(_productService.UpdateProduct(id,product));
    }

    [HttpDelete("/{id}")]
    public JsonResult DeleteProduct(int id){
        return new JsonResult(_productService.DeleteProduct(id));
    }
}
