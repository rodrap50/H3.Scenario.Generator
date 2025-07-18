namespace H3.Scenario.Generator.API.Infrastructure.Models.Data;

public class VictoryCondition
{
    public IEnumerable<string> GenericRules { get; set; } = [];
    public IEnumerable<PrimaryCondition> PrimaryConditions { get; set; } = [];
    public IEnumerable<SecondaryCondition> SecondaryConditions { get; set; } = [];
}
