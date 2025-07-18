using H3.Scenario.Generator.API.Infrastructure.Models.Data;

namespace H3.Scenario.Generator.API.Infrastructure.Services;

public interface IRepository
{
    Task<ScenarioRoot> GetSenarioData();
}
