using System;

class Lesson27{
    static void Main() {
        sum(10, 5, 2, 4, 7);
    }

    static void sum(params int[]n) {
        int res = 0;

        if(n.Length < 1) {
            Console.WriteLine("There are no value to sum");
        } else if (n.Length < 2) {
            Console.WriteLine("Insufficient values to sum: {0}", n[0]);
        } else {
            for(int i = 0; i < n.Length; i++) {
                res+=n[i];
            }
            Console.WriteLine("The sum of values is: {0}", res);
        }
    }
}