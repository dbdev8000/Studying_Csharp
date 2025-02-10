using System;

class Calculations {
    public int v1;
    public int v2;

    public Calculations(int v1, int v2) {
        this.v1 = v1;
        this.v2 = v2;
    }

    public int Sum() {
        return v1 + v2;
    }
}

class Lesson32 {
    static void Main() {

        Calculations c = new Calculations(10, 2);

        Console.WriteLine(c.Sum());

    }
}