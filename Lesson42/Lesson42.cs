using System;

class Car {
    private int[] maxSpeed = new int[5]{80, 120, 160, 240, 300};

    public int this[int i] {
        get {
            return maxSpeed[i];
        }
        set {
            if (value < 0) {
                maxSpeed[i] = 0;
            } else if(value > 300) {
                maxSpeed[i] = 300;
            } else {
                maxSpeed[i] = value;
            }
        }
    }
    public Car() {

    }
}

class Lesson42 {
    static void Main() {

        Car c1 = new Car();

        c1[4] = 200;

        Console.WriteLine("Speed: {0}", c1[4]);
    }
}