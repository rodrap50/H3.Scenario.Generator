using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H3.Scenario.Generator.API.Controller;

using System.Text.Json;
using H3.Scenario.Generator.API.Infrastructure.Models.Data;
using H3.Scenario.Generator.API.Infrastructure.Services;
using Infrastructure.Models;

[Route("api/[controller]")]
[ApiController]
public class GeneratorController(IRepository repo) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get(){
        Scenario scenario = new Scenario();
        var data = await repo.GetSenarioData();
        
        var primary = data.Alliance.PrimaryConditions.FirstOrDefault();
        Console.Write(JsonSerializer.Serialize<ScenarioRoot>(data));
        if(primary is null) return BadRequest();
        var secondary = data.Alliance.SecondaryConditions.Where(s => s.Id == primary.SecondaryId).FirstOrDefault();

        scenario.VictoryConditions = $"{primary.Condition} {secondary?.Condition}";

        return Ok(scenario);
    }
}

