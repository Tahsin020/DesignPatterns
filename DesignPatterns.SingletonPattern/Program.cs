using DesignPatterns.SingletonPattern;

var countryProvider = new CountryProvider();
var countries = await countryProvider.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}


// Another service

var countryProvider1 = new CountryProvider();
var countries1 = await countryProvider1.GetCountries();

foreach (var country in countries1)
{
    Console.WriteLine(country.Name);
}

