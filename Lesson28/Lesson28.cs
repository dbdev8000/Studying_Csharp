using System;

public class Player{
    public int stamina = 100;
    public bool alive = true;
    
}
class Lesson28 {
    static void Main() {
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();

        p1.stamina = 50;
        p1.dmg;


        Console.WriteLine("Player 1's stamina: {0}", p1.stamina);
        Console.WriteLine("Player 2's stamina: {0}", p2.stamina);
    }
}