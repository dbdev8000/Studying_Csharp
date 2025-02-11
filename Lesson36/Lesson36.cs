using System;

class Vehicle {  // Base Class
    public int currentSpeed;
    private int maxSpeed;
    protected bool isOn;

    public Vehicle(int maxSpeed) {
        currentSpeed = 0;
        this.maxSpeed = maxSpeed;
        isOn = false;
    }

    public bool getIsOn() {
        return isOn;
    }

    public int getMaxSpeed() {
        return maxSpeed;
    }
}

class Car : Vehicle {
    public string name;

    public Car(string name, int maxSpeed) : base(maxSpeed) { // Derived from Vehicle
        this.name = name;
        isOn = false;
    }
}

class Lesson036 {

    static void Main() {

        Car car = new Car("Handsome", 120);

        Console.WriteLine("Name..........: {0}", car.name);
        Console.WriteLine("Max Speed.....: {0}", car.getMaxSpeed());
        Console.WriteLine("Is On.........: {0}", car.getIsOn());
    }
}
