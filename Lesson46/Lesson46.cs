using System;

class Chicken
{
    private string nameChicken;
    private int numEgg;


    public Chicken(string nameChicken)
    {
        this.nameChicken = nameChicken;
        this.numEgg = 0;
    }

    public Egg layTheEgg()
    {
        numEgg++;
        return new Egg(numEgg, nameChicken);
    }

}

class Egg
{
    private int numEgg;
    private string myChicken;
    public Egg(int numEgg, string myChicken)
    {   
        this.numEgg = numEgg;
        this.myChicken = myChicken;
        Console.WriteLine("Created egg:{0} - {1}", this.numEgg, this.myChicken);
    }
}

class Lesson46
{
    static void Main()
    {
        Chicken c1 = new Chicken("A");
        Chicken c2 = new Chicken("B");
        Chicken c3 = new Chicken("C");

        c1.layTheEgg();
        c1.layTheEgg();
        c1.layTheEgg();

        c2.layTheEgg();

        c3.layTheEgg();
        c3.layTheEgg();

    }
}