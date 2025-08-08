using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesMostenAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilmeSerieController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("Sucesso");
    }
}
