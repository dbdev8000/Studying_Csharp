using System;

class Lesson51
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            int res = 0;

            Console.WriteLine($"Amount of arguments: {args.Length}");
            for (int i = 0; i < args.Length; i++)
            {
                res += Int32.Parse(args[i]);
            }
            Console.WriteLine($"Sum: {res}");
        }
        else
        {
            Console.WriteLine("No arguments were passed");
        }
    }
}