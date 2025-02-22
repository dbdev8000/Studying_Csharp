using System;

delegate int Op(int n1, int n2);

class Math
{
    public static int sum(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int mult(int n1, int n2)
    {
        return n1 * n2;
    }

}


class Lesson50
{
    static void Main()
    {
        int res;

        Op d1 = new Op(Math.sum);

        res = d1(10, 50);

        Console.WriteLine($"Sum: {res}");

        d1 = new Op(Math.mult);

        res = d1(10, 50);

        Console.WriteLine($"Multiplication: {res}");
    }
}