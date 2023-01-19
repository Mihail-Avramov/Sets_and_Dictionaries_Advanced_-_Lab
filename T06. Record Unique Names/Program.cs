using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());

HashSet<string> namesHashSet = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    namesHashSet.Add(Console.ReadLine());
}

foreach (var name in namesHashSet)
{
    Console.WriteLine(name);
}
