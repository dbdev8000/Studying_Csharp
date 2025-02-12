using System;

abstract class Vehicle { // Nome da classe corrigido
    protected int maxSpeed;
    protected int currentSpeed;
    protected bool on;

    public Vehicle() {
        on = false;
        currentSpeed = 0;
    }

    public void setOn(bool on) {
        this.on = on;
    }

    public int getCurrentSpeed() {
        return currentSpeed;
    }

    abstract public void acceleration(int mult);
}

class Car : Vehicle {
    public Car() {
        maxSpeed = 120;
    }

    public override void acceleration(int mult) {
        currentSpeed += 10 * mult;
    }
}

class Lesson39 {
    static void Main() {
        Car car1 = new Car(); 

        car1.acceleration(1);

        Console.WriteLine(car1.getCurrentSpeed()); 
    }
}
