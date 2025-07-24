namespace H3.Scenario.Generator.API.Infrastructure.Services;

using H3.Scenario.Generator.API.Infrastructure.Models.Data;
using H3.Scenario.Generator.API.Infrastructure.Models.Enumerators;
using Models;
using Models.Request;

public class ScenarioGenerator(IRepository repo, IRandomizer randomizer) : IScenarioGenerator
{
    public async Task<Scenario> Generate(Request? request)
    {
        Scenario scenario = new();
        var data = await repo.GetSenarioData();
        var type = request?.ScenarioType ?? 
                    randomizer.RandomFromList(
                        Enum.GetValues<ScenarioType>()
                        .Cast<ScenarioType>()
                        .ToList()
                    );

        // Set Victory Conditions
        var condition = GetVictoryCondition(ref data, type);
        var primary = randomizer.RandomFromList(condition.PrimaryConditions);
        var secondary = condition.SecondaryConditions
                        .Where(s => s.Id == primary.SecondaryId)
                        .FirstOrDefault();
        
        scenario.VictoryConditions = $"{primary.Condition} {secondary?.Condition}";
        return scenario;
    }

    private static VictoryCondition GetVictoryCondition(ref ScenarioRoot data, ScenarioType type)
    {
        VictoryCondition condition = new();
        switch (type){
            case ScenarioType.Alliance:
            {
                   condition = data.Alliance;
                break;
            }
            case ScenarioType.Clash:
            {
                    condition = data.Clash;
                break;
            }
            case ScenarioType.Single:{
                    condition = data.SIngle;
                break;
            }
            case ScenarioType.CoOp:{
                    condition = data.CoOp;
                break;
            }
        }
        return condition;
    }
}