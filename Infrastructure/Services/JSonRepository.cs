namespace H3.Scenario.Generator.API.Infrastructure.Services;

using System.Text.Json;
using H3.Scenario.Generator.API.Infrastructure.Models.Data;
using H3.Scenario.Generator.API.Infrastructure.Services;
using Microsoft.AspNetCore.Http.Json;

public class JSonRepository : IRepository
{
    public async Task<ScenarioRoot> GetSenarioData(){
        try{

        var json = await File.ReadAllTextAsync ("./Infrastructure/Data/VictoryCondition.json");
        if(string.IsNullOrEmpty(json)) throw new Exception("Failed to read Json as it was empty");

        Console.Write(json);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        };

        var scenarios = JsonSerializer.Deserialize<ScenarioRoot>(json, options);
        if(scenarios is null) throw new Exception("JSon Didnt Deserialize");
        return scenarios;
        }
        catch{
            throw;
        }
    }
}