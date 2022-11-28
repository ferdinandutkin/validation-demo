using Microsoft.AspNetCore.Mvc;
using validation.Attributes;
using validation.Data.Abstractions;

namespace validation.Controllers;

[ApiController]
[Route("[controller]")]
public class EntitiesController : ControllerBase
{
    [HttpGet("ducks/{id}")]
    public IActionResult GetDuck([DuckId] int id)
    {
        return Ok("Duck. Service reached");
    }
    
    
    [HttpGet("cats/{id}")]
    public IActionResult GetCat([CatId] int id)
    {
        return Ok("Cat. Service reached");
    }
}