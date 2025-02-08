using System;

class Lesson19 {
    static void Main() {
        //int num;

        int[] num = new int[10];

        for (int i = 0; i < num.Length; i++) {
            num[i] = i;
        }

        for (int i = 0; i < num.Length; i++) {
             Console.WriteLine("The value of num in position {0}: {1}", i, num[i]);
        }
    }
}