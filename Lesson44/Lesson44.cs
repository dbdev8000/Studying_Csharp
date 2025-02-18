using System;

struct Car
{
    public string carBrand;
    public string carModel;
    public string carColor;

    public Car(string carBrand, string carModel, string carColor)
    {
        this.carBrand = carBrand;
        this.carModel = carModel;
        this.carColor = carColor;
    }

    public void info()
    {
        Console.WriteLine("\nBrand: {0}", this.carBrand);
        Console.WriteLine("Model: {0}", this.carModel);
        Console.WriteLine("Color: {0}", this.carColor);
    }
}

class Lesson44
{
    static void Main()
    {
        Car c1;

        c1.carBrand = "VW";
        c1.carModel = "Golf";
        c1.carColor = "Red";

        Car c2 = new Car("Honda", "HRV", "Blue");

        c1.info();

        c2.info();

    }
}