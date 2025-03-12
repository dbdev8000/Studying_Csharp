using System;
using System.Collections.Generic;

class Lesson56
{
    static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Car");
        transp.AddFirst("Bike");
        transp.AddFirst("Airplane");
        transp.AddFirst("Motorcycle");

        transp.AddLast("Ship");

        LinkedListNode<string>no;
        no = transp.FindLast("Ship");
        transp.AddAfter(no, "Scooter" );

        if (transp.Find("Car") == null)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            Console.WriteLine("Element found");
        }

        foreach (string t in transp)
        {
            Console.WriteLine("Transport: {0}", t);
        }
    }
}