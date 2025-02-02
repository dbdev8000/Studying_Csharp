using System;

class Lesson03{
    static void Main(){
        byte n1 = 18; // 0 & 255
        int num = 2006; // 
        char letter = 'M';
        float value = 5.6f;
        string name = "Daniel";


        var aux = 10;

        Console.WriteLine("My name is " + name + " and i have " + n1 + " years, because i was born in " + num );
        
        int num1, num2, res;

        num1 = 10;
        num2 = 88;
        res = num1 + num2;

        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + res);

    }
}