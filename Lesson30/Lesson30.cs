using System;

public class Player{
    public int stamina;
    public bool alive;
    public string name;

    public Player() {
        stamina = 100;
        alive = true;
        name = "Player";
    }

    public Player(string n) {
        stamina = 100;
        alive = true;
        name = n;
    }

    public Player(string n, int s) {
        stamina = s;
        alive = true;
        name = n;
    }

    public Player(string n, int s, bool a) {
        stamina = s;
        alive = a;
        name = n;
    }

    public void info() {
        Console.WriteLine("Name player...: {0}\n", name);
        Console.WriteLine("Stamina player: {0}\n", stamina);
        Console.WriteLine("Stats player..: {0}\n", alive);
    }

    public void info(int n) {
        Console.WriteLine("Name player...: {0}\n", name);
        Console.WriteLine("Stamina player: {0}\n", stamina);
        Console.WriteLine("Stats player..: {0}\n", alive);
    }
}
class Lesson30 {
    static void Main() {
        Player p1 = new Player();
        Player p2 = new Player("Luffy");
        Player p3 = new Player("Nami", 99);
        Player p4 = new Player("White Beard", 0, false);

        p1.info();
        p2.info();
        p3.info();
        p4.info();
    }
}
