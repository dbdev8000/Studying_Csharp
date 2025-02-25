using System;

class Area
{
    public static float Square(float bas, float height)
    {
        if (bas == 0 || height == 0)
        {
            throw new Exception("Base or height cannot be equal to zero");
        }
        return bas * height;
    }
}


class Lesson53
{
    static void Main()
    {
        float area = 0;
        
        try
        {
            area = Area.Square(10f, 0);
            Console.WriteLine($"Area of square.: {area}");
        }
        catch(Exception e)
        {
            Console.WriteLine($"ERRO: {e.Message}");
        }
        finally
        {
            Console.WriteLine("End of process");
        }
    }
}