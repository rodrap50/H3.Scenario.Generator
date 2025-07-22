namespace H3.Scenario.Generator.API.Infrastructure.Services;
using Models;
using Models.Request;
public class ScenarioGenerator(IRepository repo, IRandomizer randomizer) : IScenarioGenerator
{
    public async Task<Scenario> Generate(Request? request)
    {
        Scenario scenario = new Scenario();
        var data = await repo.GetSenarioData();
        
        var primary = randomizer.RandomFromList(data.Alliance.PrimaryConditions);
        //Console.Write(JsonSerializer.Serialize<ScenarioRoot>(data));
        if(primary is null) throw new Exception("Failed to Generate data");
        var secondary = data.Alliance.SecondaryConditions.Where(s => s.Id == primary.SecondaryId).FirstOrDefault();

        scenario.VictoryConditions = $"{primary.Condition} {secondary?.Condition}";
        return scenario;
    }
}