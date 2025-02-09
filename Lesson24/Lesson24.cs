using System;

class Lesson24 {
    static void Main() {
        int v1, v2;
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of {0} e {1} is: {2}", v1,v2, sum(v1,v2));
    }

    static int sum(int n1, int n2) {
        int res = n1 + n2;
        return res;
    }

}