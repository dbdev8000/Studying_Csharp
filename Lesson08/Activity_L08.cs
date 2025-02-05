using System;

class Activity_L08{
    static void Main(){
        string name, superPower;
        int age;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your super power: ");
        superPower = Console.ReadLine();
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your name is {0}, you have the super power of {1} and have {2} years old", name, superPower, age);

    }
}