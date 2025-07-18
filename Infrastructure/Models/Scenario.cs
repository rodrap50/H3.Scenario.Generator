namespace H3.Scenario.Generator.API.Infrastructure.Models;

public class Scenario{
    public string Name {get; set;} = "";
    public int PlayerCount {get; set;} = 1;
    public int ScenarioLength {get; set;} = 0;
    public MapSetup Map {get; set;} = new(); 
    public Resources StartingResources { get; set ;} = new();
    public Resources StartingIncome {get; set; } = new();
    public Buildings StartingBuilding { get; set; } = new();
    public Units StartingUnits { get; set; } = new();
    public IEnumerable<string> ScenarioRules { get; set; } = [];
    public string VictoryConditions { get; set; } = "";
    public int RoundTrackers {get; set;} = 0;
    public IEnumerable<string> TimedEvents {get; set;} = [];
}