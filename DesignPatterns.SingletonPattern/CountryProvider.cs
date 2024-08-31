using DesignPatterns.SingletonPattern.Models;

namespace DesignPatterns.SingletonPattern;
public class CountryProvider
{
    private CountryProvider()
    {
        Task.Delay(2000).GetAwaiter().GetResult();

        Countries = [
            new(){Name = "Türkiye"},
            new(){Name = "Hollanda"}
        ];
    }

    private static CountryProvider instance = null;
    public static CountryProvider Instance => instance ?? (instance = new CountryProvider());
    private new List<Country> Countries { get; set; }
    public async Task<List<Country>> GetCountries() => Countries;

    public int CountryCount => Countries.Count;
}
