using System;

class Lesson0{
    static void Main(){

        double purchaseValue = 5.50;
        double saleValue;
        double profit = 0.1;
        string product = "Brigadeiro";

        saleValue = purchaseValue + (purchaseValue * profit);

        Console.WriteLine("Poduct................:{0,15}", product);
        Console.WriteLine("Purchase.Value........:{0,15:c}", purchaseValue);
        Console.WriteLine("profit................:{0,15:p}", profit);
        Console.WriteLine("Sale.Value............:{0,15:c}", saleValue);

    }
}