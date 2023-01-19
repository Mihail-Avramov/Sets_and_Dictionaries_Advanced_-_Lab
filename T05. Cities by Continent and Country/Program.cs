using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());

Dictionary<string,Dictionary<string,List<string>>> continentsCountriesCities = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] inputArguments = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string continent = inputArguments[0];
    string country = inputArguments[1];
    string city = inputArguments[2];

    if (!continentsCountriesCities.ContainsKey(continent))
    {
        continentsCountriesCities[continent] = new Dictionary<string, List<string>>();
    }

    if (!continentsCountriesCities[continent].ContainsKey(country))
    {
        continentsCountriesCities[continent][country] = new List<string>();
    }

    //if (!continentsCountriesCities[continent][country].Contains(city))
    //{
    //    continentsCountriesCities[continent][country].Add(city);
    //}

    continentsCountriesCities[continent][country].Add(city);

}

foreach (var continent in continentsCountriesCities)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
    }
}