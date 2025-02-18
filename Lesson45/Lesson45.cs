using System;

struct Car
{
    public string carModel;
    public string carColor;

    public void info()
    {
        Console.WriteLine("Model: {0}", this.carModel);
        Console.WriteLine("Color: {0}", this.carColor);
        Console.WriteLine("------------------------------");
    }
}

class Lesson45
{
    static void Main()
    {
        Car[] Cars = new Car[4];

        Cars[0].carModel = "HRV";
        Cars[0].carColor = "Green";

        Cars[1].carModel = "Golf";
        Cars[1].carColor = "Red";

        Cars[2].carModel = "Jetta";
        Cars[2].carColor = "Brown";

        Cars[3].carModel = "Argo";
        Cars[3].carColor = "Back";

        for(int i = 0; i < Cars.Length ;i++)
        {
            Cars[i].info
        }
    }
}