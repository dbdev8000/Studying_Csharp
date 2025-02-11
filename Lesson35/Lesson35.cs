using System;

class Vehicle { // Base Class
    private int wheels;
    public int maxSpeed;
    private bool on;

    public Vehicle(int wheels) {
        this.wheels = wheels;
    }

    public void startTheCar() {
        on = true;
    }

    public void turnOffTheCar() {
        on = false;
    }

    public string getOn() {
        return(on?"Yes" : "No");

    }
    public int getWheels() {
        return wheels;
    }

    public void setWheels(int wheels) {
        if( wheels < 0) {
            this.wheels = 0;
        } else if(wheels > 40) {
            this.wheels = 40;
        } else {
            this.wheels = wheels;
        }
    }
}

class Car : Vehicle { //Derived Class
    public string name;
    public string color;

    public Car(string name, string color) : base(4) {
        turnOffTheCar();
        maxSpeed = 120;
        this.name = name;
        this.color = color;
    }
}

class CombatCar : Car {
    public int bullets;
    public CombatCar() : base ("Combat Car", "Black") {
        bullets = 100;
        setWheels(6);
    }
}

class Lesson35 {
    static void Main() {
        Car c1 = new Car("Speederman", "Red");
        CombatCar c2 = new CombatCar();

        c1.startTheCar();

        Console.WriteLine("Color....: {0}", c2.color);
        Console.WriteLine("Name.....: {0}", c2.name);
        Console.WriteLine("Wheels...: {0}", c2.getWheels());
        Console.WriteLine("Max Speed: {0}", c2.maxSpeed);
        Console.WriteLine("On.......: {0}", c2.getOn());
        Console.WriteLine("Bullets.. : {0}", c2.bullets);

        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Color....: {0}", c1.color);
        Console.WriteLine("Name.....: {0}", c1.name);
        Console.WriteLine("Wheels...: {0}", c1.getWheels());
        Console.WriteLine("Max Speed: {0}", c1.maxSpeed);
        Console.WriteLine("On.......: {0}", c1.getOn());
    }
}
