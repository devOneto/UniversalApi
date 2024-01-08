using Microsoft.AspNetCore.Mvc;
using UniversalApi.Models;

namespace UniversalApi.Controllers;

[ApiController]
[Route("[controller]")]
public class InfoController : ControllerBase
{
    public InfoController() { }

    [HttpGet]
    public Info Get() => new Info{ Version = "0.0.1", Description = "Universal - 3D Level Editor." };
    
}
