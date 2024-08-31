using DesignPatterns.SingletonPattern;

var countries = await CountryProvider.Instance.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}


// Another service

var countries1 = await CountryProvider.Instance.GetCountries();

foreach (var country in countries1)
{
    Console.WriteLine(country.Name);
}

