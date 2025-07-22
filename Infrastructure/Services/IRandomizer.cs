namespace H3.Scenario.Generator.API.Infrastructure.Services;

public interface IRandomizer
{
    T RandomFromList<T>(IEnumerable<T> values);
}
