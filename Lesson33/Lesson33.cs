using System;

class Player {
    private int stamina;
    private string name;

    public Player(string name) {
        this.name = name;
        stamina = 100;
    }

    public int getStamina() {
        return stamina;
    }

    public string getName() {
        return name;
    }

    public void setStamina(int s) {
        if(s < 0) {
            if(stamina + s < 0) {
                stamina = 0;
            } else {
                stamina += s;
            }
        } else if(s > 0) {
            if(stamina + s > 100) {
                stamina = 100;
            } else {
                stamina += s;
        }
    }
}
class Lesson33 {
    static void Main() {
        Player p1 = new Player("Luffy");

        p1.setStamina(50c);

        Console.WriteLine("Name...: {0}", p1.getName());
        Console.WriteLine("Stamina: {0}", p1.getStamina());

        }
    }
}