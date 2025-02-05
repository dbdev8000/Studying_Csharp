using System;
class Activity_L10{
    enum colors {Green, White, Blue, Brown};
    static void Main(){

       int n = 0;

       colors color;

       Console.Write("Enter a value(0 -> 3): ");
       n = int.Parse(Console.ReadLine());
       color = (colors)n;
       Console.WriteLine("Your luck color is: {0}", color);
    }
}