using System;

class Lesson08{
    static void Main(){
        int v1, v2, sum;

        Console.Write("Enter first value: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second value: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        sum = v1 + v2;
        Console.WriteLine("The sum of {0} plus {1} is equal to {2} ", v1, v2, sum);



    }
}