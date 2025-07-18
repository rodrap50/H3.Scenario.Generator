namespace H3.Scenario.Generator.API.Infrastructure.Services;

using System.Text.Json;
using H3.Scenario.Generator.API.Infrastructure.Models.Data;
using H3.Scenario.Generator.API.Infrastructure.Services;

public class JSonRepository : IRepository
{
    public async Task<ScenarioRoot> GetSenarioData(){

        var json = await File.ReadAllTextAsync ("./Infrastructure/Data/VictoryCondition.json");

        var scenarios =  JsonSerializer.Deserialize<ScenarioRoot>(json);

        return scenarios;
    }
}