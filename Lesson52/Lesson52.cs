using System;

class Lesson52
{
    static void Main()
    {
        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 0;

        try
        {
        res = n1 / n2;
        Console.WriteLine($"{n1}/{n2} = {res}");
        }
        catch(Exception e)
        {
            Console.WriteLine($"ERRO: {e.Message}");
            Console.WriteLine($"Ex: {e.GetType()}");

        }
    }
}