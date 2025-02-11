using System;

class Base {
    public Base() {
        Console.WriteLine("Constructor of Base class");
    }
}

class Derivative1 : Base {
    public Derivative1() {
        Console.WriteLine("Constructor of Derivative1 class");
    }
}

class Derivative2 : Derivative1 {
    public Derivative2() {
        Console.WriteLine("Constructor of Derivative2 class");
    }
}

class Lesson37 {
    static void Main() {
        Derivative2 derivative2 = new Derivative2();
    }
}