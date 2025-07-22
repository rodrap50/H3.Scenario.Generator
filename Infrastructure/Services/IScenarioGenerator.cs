
namespace H3.Scenario.Generator.API.Infrastructure.Services;
using Models.Request;
using Models;

public interface IScenarioGenerator
{
    Task<Scenario> Generate(Request? request);
}