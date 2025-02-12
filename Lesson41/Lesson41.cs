using System;

class Car {
    private int maxSpeed;

    public int ms {
        get {
            return maxSpeed;
        }
        set {
            if (value < 0) {
                maxSpeed = 0;
            } else if(value > 300) {
                maxSpeed = 300;
            } else {
                maxSpeed = value;
            }
        }
    }
    public Car() {
        ms = 120;
    }

}

class Lesson41 {
    static void Main() {
        Car c1 = new Car();

        c1.ms = 200;

        Console.WriteLine("Speed: {0}", c1.ms);
    }
}