using System;
using System.Collections.Generic;


HashSet<string> vipHashSet = new HashSet<string>();
HashSet<string> regularHashSet = new HashSet<string>();

string input;
while ((input = Console.ReadLine()) != "END")
{
    if (input == "PARTY")
    {
        while ((input = Console.ReadLine()) != "END")
        {
            if (char.IsDigit(input[0]))
            {
                vipHashSet.Remove(input);
            }
            else
            {
                regularHashSet.Remove(input);
            }
        }
        break;
    }
    else
    {
        if (char.IsDigit(input[0]))
        {
            vipHashSet.Add(input);
        }
        else
        {
            regularHashSet.Add(input);
        }
    }
}

int count = vipHashSet.Count + regularHashSet.Count;

Console.WriteLine(count);

if (vipHashSet.Count > 0)
{
    Console.WriteLine(String.Join(Environment.NewLine, vipHashSet));
}

if (regularHashSet.Count > 0)
{
    Console.WriteLine(String.Join(Environment.NewLine, regularHashSet));
}