using System;

static public class Player{
    static public int stamina;
    static public bool alive;
    static public string name;

    static public void init(string n) {
        stamina = 100;
        alive = true;
        name = n;
    }

    static public void info() {
        Console.WriteLine("Name player...: {0}\n", name);
        Console.WriteLine("Stamina player: {0}\n", stamina);
        Console.WriteLine("Stats player..: {0}\n", alive);
    }
}

class Enemy {
    static public bool alert;
    public string name;

    public Enemy(string n) {
        alert = false;
        name = n;
    }

    public void info() {
        Console.WriteLine(name);
        Console.WriteLine(alert);
        Console.WriteLine("------------------------------");
    }
}

class Lesson31 {
    static void Main() {
    
        Player.init("Goku");
        Player.info();

        Enemy e1 = new Enemy("Vegeta");
        Enemy e2 = new Enemy("Vegeta");
        Enemy e3 = new Enemy("Cells");

        Enemy.alert = true;

        e1.info();
        e2.info();
        e3.info();
    }
}
