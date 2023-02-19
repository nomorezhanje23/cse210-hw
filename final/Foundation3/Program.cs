using System;

class Program
{
    static void Main(string[] args)
    { 
        int userMenuInput = 0;

        List<string>menu = new List<string>
        {
            "Event Options:",
            "  1. Lecturer event",
            "  2. Reception event",
            "  3. Outdoor Gathering",
            "  4. Quit"
        };

        while (userMenuInput !=4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the event: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
               case 1:
                      Lecture Activity = new Lecture ();
                      Activity.runActivity();
                      break;
                

                case 2:
                       Reception activity = new Reception();
                       activity.runActivity();
                       break;

                case 3:
                       OutdoorGathering activity1  = new OutdoorGathering();
                       activity1.runActivity();
                       break;

                case 4:
                     
                       break;

            }
        }
      
    }
}