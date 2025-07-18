using System.Text.Json.Serialization;

namespace H3.Scenario.Generator.API.Infrastructure.Models.Data;

public class ScenarioRoot
{
    [JsonPropertyName("co-op")]
    public VictoryCondition CoOp { get; set; } = new();
    public VictoryCondition Alliance { get; set; } = new();
    public VictoryCondition Clash { get; set; } = new();
    public VictoryCondition SIngle { get; set; } = new();
}
