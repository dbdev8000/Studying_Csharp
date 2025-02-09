using System;

class Lesson25{
    static void Main(){
        int num = 50;
        Double(ref num);
        Console.WriteLine(num);
    }

    static void Double (ref int value) {
        value *= 2;
    }
}