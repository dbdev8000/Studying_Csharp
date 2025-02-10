using System;

public class Player{
    public int stamina;
    public bool alive;

    public string name;

    public Player(string n) {
        stamina = 100;
        alive = true;
        name = n;
    }
    ~Player() {
        Console.WriteLine("PLAYER {0} WAS DESTROYED", name);
    }
}
class Lesson29 {
    static void Main() {
        string name1;
        Console.WriteLine("Enter player name 1: ");
        name1 = Console.ReadLine();
        Player p1 = new Player(name1);
        Player p2 = new Player("Thomaz");

        p1.stamina = 50;

        Console.WriteLine("{1}'s stamina: {0}", p1.stamina, p1.name);
        Console.WriteLine("{1}'s stamina: {0}", p2.stamina, p2.name);
    }
}
