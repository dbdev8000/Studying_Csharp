using System;
using System.Collections.Generic;

class Lesson55
{
    static void Main()
    {
        Dictionary <int, string> vehicles = new Dictionary <int, string>();

        vehicles.Add(10, "Car");
        vehicles.Add(5, "Airplane");
        vehicles.Add(0, "Ship");
        vehicles.Add(20, "motorcycle");
        vehicles.Add(15, "Bike");

        //vehicles.Clear();

        vehicles.Remove(20);

        Console.WriteLine("Size of Dictionary: {0}", vehicles.Count);

        int key = 20;

        if(vehicles.ContainsKey(key))
        {
            Console.WriteLine("The key {0} is in the collection", key);
        }
        else
        {
            Console.WriteLine("The key {0} is not in the collection", key);
        }

        vehicles[15] = "Scooter";

        string value = "Scooter";

        if (vehicles.ContainsValue(value))
        {
            Console.WriteLine("The value {0} is in the collection",value);
        }
        else
        {
            Console.WriteLine("The value {0} is not in the collection",value);
        }

        Dictionary<int, string>.ValueCollection values = vehicles.Values;


        foreach (string v in values)
        {
            Console.WriteLine(v);
        }
    }
}
