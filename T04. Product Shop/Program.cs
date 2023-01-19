using System;
using System.Collections.Generic;
using System.Linq;

SortedDictionary<string,Dictionary<String, double>> foodShopsInformation = new SortedDictionary<string, Dictionary<string, double>>();

string input;

while ((input = Console.ReadLine()) != "Revision")
{
    string[] informationArguments = input.Split(", ").ToArray();

    string shopName = informationArguments[0];
    string foodName = informationArguments[1];
    double price = double.Parse(informationArguments[2]);

    if (!foodShopsInformation.ContainsKey(shopName))
    {
        foodShopsInformation[shopName] = new Dictionary<string, double>();
    }

    foodShopsInformation[shopName][foodName] = price;
}

foreach (var shop in foodShopsInformation)
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var food in shop.Value)
    {
        Console.WriteLine($"Product: {food.Key}, Price: {food.Value}");
    }
}