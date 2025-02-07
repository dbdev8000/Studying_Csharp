using System;

class Lesson13{
    static void Main(){

        int g1, g2, g3, g4, res;
        res = g1 = g2 = g3 = g4 = 0;
        string result;

        Console.Write("Type grade 1: ");
        g1 = int.Parse(Console.ReadLine());

        Console.Write("Type grade 2: ");
        g2 = int.Parse(Console.ReadLine());

        Console.Write("Type grade 3: ");
        g3 = int.Parse(Console.ReadLine());

        Console.Write("Type grade 4: ");
        g4 = int.Parse(Console.ReadLine());

        res = g1+g2+g3+g4;

        //>=60 - Passed!
        //59 & 40 Remedial!
        //<40 Failed!

        if(res < 40){
            result = "You failed!";
        } else if (res < 60 ){
            result = "You are in remedial classes!";
        } else {
            result = "You passed!";
        }
        
        Console.WriteLine("Grade: {0} - Result: {1}", res, result);
    }
}