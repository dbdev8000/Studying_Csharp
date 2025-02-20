using System;

class Calc
{
    public int sum (params int[]n)
    {
        int s = 0;
        for(int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }

    public double sum (params double[]n)
    {
        double s = 0;
        for(int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }

}

class Lesson47
{
    static void Main()
    {
        Calc calc = new Calc();

        var res = calc.sum(10.2, 5.4, 4, 6.0, 5.5, 2, 7.8, 30, 10, 20);

        Console.WriteLine(res);

    }
}