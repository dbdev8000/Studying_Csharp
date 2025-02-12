using System;

class Base {
    public Base() {
        Console.WriteLine("Constructor of Base class");
    }

    virtual public void info() {
        Console.WriteLine("Base");
    }
}

class Derivative1 : Base {
    public Derivative1() {
        Console.WriteLine("Constructor of Derivative1 class");
    }
    override public void info() {
        Console.WriteLine("Derivative1");
    }
}

class Derivative2 : Derivative1 {
    public Derivative2() {
        Console.WriteLine("Constructor of Derivative2 class");
    }
    override public void info() {
        Console.WriteLine("Derivative2");
    }
}

class Lesson38 {
    static void Main() {
        Base Ref;
        Derivative1 derivative1 = new Derivative1();
        Derivative2 derivative2 = new Derivative2();
        
        
        Ref = derivative1;
        Ref.info();
    }
}