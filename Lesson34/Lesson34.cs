using System;

class Vehicle { // Base Class
    public int wheels;
    public int maxSpeed;
    private bool on;

    public void startTheCar() {
        on = true;
    }

    public void turnOffTheCar() {
        on = false;
    }

    public string getOn() {
        if (on) {
            return "Yes";
        } else {
            return "No";
        }
    }
}

class Car : Vehicle { //Derived Class
    public string name;
    public string color;

    public Car(string name, string color) {
        startTheCar();
        wheels = 4;
        maxSpeed = 120;
        this.name = name;
        this.color = color;
    }
}

class Lesson34 {
    static void Main() {
        Car c1 = new Car("Speederman", "Red");

        Console.WriteLine("Color....: {0}", c1.color);
        Console.WriteLine("Name.....: {0}", c1.name);
        Console.WriteLine("Wheels...: {0}", c1.wheels);
        Console.WriteLine("Max Speed: {0}", c1.maxSpeed);
        Console.WriteLine("On.......: {0}", c1.getOn());
    }
}
