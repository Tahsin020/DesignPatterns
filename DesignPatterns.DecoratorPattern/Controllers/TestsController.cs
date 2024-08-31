using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.DecoratorPattern.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestsController : ControllerBase
{

    [HttpGet("Test")]
    public IActionResult Get()
    {
        return Ok();
    }



}
