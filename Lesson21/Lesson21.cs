using System;

class Lesson21 {
    static void Main() {

        string password = "123"; 
        string passworduser;
        int attempts = 0;
        
        do {
            Console.Clear();
            Console.WriteLine("Type the password");
            passworduser = Console.ReadLine();  
            attempts++;      
        } while(password != passworduser);
        
        Console.Clear();
        Console.WriteLine("Correct password, attempts: {0}", attempts);


    }
}