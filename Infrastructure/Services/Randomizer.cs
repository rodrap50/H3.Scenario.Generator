namespace H3.Scenario.Generator.API.Infrastructure.Services;

public class Randomizer : IRandomizer
{
    public T RandomFromList<T>(IEnumerable<T> values){

        var count = values.Count();
        var index = Random.Shared.Next(0,count);
        var ret = values.ElementAt(index);

        return ret;

    }
}
