using System;
using System.Collections.Generic;

HashSet<string> carPlates = new HashSet<string>();

string input;

while ((input = Console.ReadLine()) != "END")
{
    string[] commandArguments = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string direction = commandArguments[0];
    string carPlate = commandArguments[1];

    switch (direction)
    {
        case "IN":
            carPlates.Add(carPlate);
            break;
        case "OUT":
            carPlates.Remove(carPlate);
            break;
    }
}

if (carPlates.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (var carPlate in carPlates)
    {
        Console.WriteLine(carPlate);
    }
}