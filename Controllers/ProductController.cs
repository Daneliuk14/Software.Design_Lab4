using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Software.Design.Services;

namespace Software.Design.Models.Controllers;

[ApiController]
[Route("api/Keyboards")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly KeyboardServices _keyboardServices;


    public ProductController(
        ILogger<ProductController> logger,
        KeyboardServices keyboardServices)
    {
        _logger = logger;
        _keyboardServices = keyboardServices;
    }

    [HttpGet]
    public async Task<ActionResult<List<Keyboard>>> GetProducts()
    {
        var products = await _keyboardServices.GetProducts();
        return Ok(products);
    }

    [HttpGet("{ID}")]
    public async Task<ActionResult<object>> GetProduct(int ID)
    {
        var value = await _keyboardServices.Get(ID);
        return Ok(value);
    }

    [HttpPost]
    public async Task<ActionResult<object>> CreateProduct(KeyboardDTO keyboardDTO)
    {
        var product = await _keyboardServices.Create(keyboardDTO);
        return Created(product);
    }

    [HttpPut("{ID}")]
    public async Task<ActionResult<object>> UpdateProduct(int ID, KeyboardDTO keyboardDTO)
    {
        var value = await _keyboardServices.Update(ID, keyboardDTO);
        return Ok(value);
    }

    [HttpDelete("{ID}")]
    public async Task<ActionResult<object>> DeleteProduct(int ID)
    {
        var value = await _keyboardServices.Delete(ID);
        return Ok(value);
    }


    private ObjectResult Created(object value)
    {
        return StatusCode(201, value);
    }
}
