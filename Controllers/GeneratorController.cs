using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H3.Scenario.Generator.API.Controller;
using Infrastructure.Models;

[Route("api/[controller]")]
[ApiController]
public class GeneratorController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(){
        Scenario scenario = new Scenario();
        return Ok(scenario);
    }
}

