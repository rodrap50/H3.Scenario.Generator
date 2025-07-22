using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H3.Scenario.Generator.API.Controllers;

using System.Text.Json;
using H3.Scenario.Generator.API.Infrastructure.Models.Data;
using H3.Scenario.Generator.API.Infrastructure.Models.Request;
using H3.Scenario.Generator.API.Infrastructure.Services;
using Infrastructure.Models;

[Route("api/[controller]")]
[ApiController]
public class GeneratorController(IScenarioGenerator gen) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery]Request? request)
    {
        Scenario scenario = await gen.Generate(request);
        return Ok(scenario);
    }
}

