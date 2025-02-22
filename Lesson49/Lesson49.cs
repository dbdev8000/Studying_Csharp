using System;

class Math
{
    public static double pi = 3.14;
    
    public static int doub(int n)
    { 
        return n*2;
    }
}

class Lesson49
{
    static void Main()
    {
        double vpi = Math.pi;
        int num = 10;

        Console.WriteLine(vpi);
        Console.WriteLine(Math.doub(num));
    }
}

