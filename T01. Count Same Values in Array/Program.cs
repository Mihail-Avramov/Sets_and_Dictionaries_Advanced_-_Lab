using System;
using System.Collections.Generic;
using System.Linq;


Dictionary<double, int> doubleCountValues = new Dictionary<double, int>();

double[] numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

foreach (var number in numbers)
{
    if (!doubleCountValues.ContainsKey(number))
    {
        doubleCountValues.Add(number,0);
    }

    doubleCountValues[number]++;
}

foreach (var kvp in doubleCountValues)
{
    Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
}
