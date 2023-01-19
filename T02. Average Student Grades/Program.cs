using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] inputArguments = Console.ReadLine().Split(' ');
    string name = inputArguments[0];
    decimal grade = decimal.Parse(inputArguments[1]);

    if (!studentsGrades.ContainsKey(name))
    {
        studentsGrades[name] = new List<decimal>();
    }

    studentsGrades[name].Add(grade);
}

foreach (var studentGrades in studentsGrades)
{
    Console.WriteLine($"{studentGrades.Key} -> {string.Join(" ", studentGrades.Value.Select(x => $"{x:f2}"))} (avg: {studentGrades.Value.Average():f2})");
}