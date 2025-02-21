using System;

class Calc
{
    public int sum(params int[] n)
    {
        int s = 0;
        for (int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }

    public double sum(params double[] n)
    {
        double s = 0;
        for (int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }

    //5! = 5*4*3*2*1
    public int fac(int n)
    {
        int res;

        if(n <= 1)
        {
            res = 1;
        }
        else
        {
            res = n*fac(n - 1);
        }
        return res;
    }

}

class Lesson48
{
    static void Main()
    {
        Calc calc = new Calc();

        var res = calc.fac(5);


        Console.WriteLine(res);   
    }
}