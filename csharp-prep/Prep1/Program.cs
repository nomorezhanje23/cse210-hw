using System;

class Program
{
    static void Main(string[] args)
    {    //Asking the name
        Console.Write("What is your first name? ");
        
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"My name is {first}, {first} {last}");
    
    }
}