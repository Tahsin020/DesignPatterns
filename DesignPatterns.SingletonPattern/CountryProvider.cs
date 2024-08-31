using DesignPatterns.SingletonPattern.Models;

namespace DesignPatterns.SingletonPattern;
public sealed class CountryProvider
{
    public async Task<List<Country>> GetCountries()
    {
        // retrieving data from db
        await Task.Delay(2000);
        return
        [
            new(){Name = "Türkiye"},
            new(){Name = "Hollanda"}
        ];
    }
}
