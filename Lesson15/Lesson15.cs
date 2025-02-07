using System;

class Lesson15{
    static void Main(){

        int time = 0;
        char choice;

        Console.WriteLine("São José dos Campos/SP to Rio de Janeiro/RJ");
        Console.WriteLine("Choose the transport: [a] = Airplane | [b] = Bus | [c] = Car ");

        choice = char.Parse(Console.ReadLine());

        switch(choice){
            case 'a': 
            case 'A': 
                time = 50;
                break;

            case 'b':
            case 'B': 
                time = 300;
                break;

            case 'c':
            case 'C': 
                time = 360;
                break;

            default:
                time = -1;
                break;
        }

        if(time < 0) {
            Console.WriteLine("transport unavailable");
    } else {
        Console.WriteLine("For the chosen transport, the time is: {0} minutes", time);
        }
    }
}