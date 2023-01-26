using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

      

        DisplayResultMessage();

    }

    private static void DisplayResultMessage()
    {
        throw new NotImplementedException();
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to your journal, a place where memories live!");
       
    }

    static void DisplayResultMessage(int prompt)
    {
        Console.WriteLine("Have a great day");
    }
}