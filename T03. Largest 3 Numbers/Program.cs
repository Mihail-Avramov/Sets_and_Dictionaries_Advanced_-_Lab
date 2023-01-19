using System;
using System.Linq;

int[] numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));