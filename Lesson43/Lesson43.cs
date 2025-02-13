using System;

public interface Vehicle {
    void turnOn();
    void turnOff();
    void info();
}

public interface Combat {
    void attack();
}

class Car : Vehicle, Combat {

    public bool on;

private int bullets;
    public Car() {
        setBullets(100);
    }

    public void setBullets(int amount ) {
        this.bullets = amount;
    }

    public void turnOn() {
        this.on = true;

    }

    public void turnOff() {
        this.on = false;
        
    }

    public void attack() {

    }

    public void info() {}
}
class Lesson {
    static void Main() {
        
        Car c1 = new Car();
    }
}