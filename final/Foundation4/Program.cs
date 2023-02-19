using System;

class Program
{
    static void Main(string[] args)
    { 
        int userMenuInput = 0;

        List<string>menu = new List<string>
        {
            "Menu Options:",
            "  1. Start running activity",
            "  2. Start cycling activity",
            "  3. Start swimming activity",
            "  4. Quit"
        };

        while (userMenuInput !=4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
               case 1:
                      Running Activity = new Running ();
                      Activity.runActivity();
                      break;
                

                case 2:
                       Cycling activity = new Cycling();
                       activity.runActivity();
                       break;

                case 3:
                       Swimming activity1  = new Swimming();
                       activity1.runActivity();
                       break;

                case 4:
                     
                       break;

            }
        }
      
    }
}