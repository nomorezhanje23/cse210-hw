using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string entry();
        string prompt();

        DisplayResultMessage();

    }

    private static void DisplayResultMessage()
    {
        throw new NotImplementedException();
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to your journal, a place where memories live!");
        Console.WriteLine ("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

    }

    static string entry()
    {
        Console.Write("What would you like to do? ");
        magicNumber = int.Parse(Console.ReadLine());

        return magicNumber; 

         Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 6);

        int prompt = -1;

        while (prompt == magicNumber)

        {
              

              if (prompt == 1)
              {
                Console.WriteLine("If I had one thing I could do today what would it be? ");
              }
              //else if (prompt == 2)


    }


        }


    static void DisplayResultMessage(int prompt)
    {
        Console.WriteLine("Have a great day");
    }
}