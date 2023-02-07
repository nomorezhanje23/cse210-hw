class ListingActivity : Activity
{
    List<string> prompt,questions;

    public ListingActivity() : base()
    {
        setActivityName ("Listing Activity");

        setDescription ("This activity will help you reflect on the good" + 
        " things in your life by having you list as many things" + 
        " as you can in a certain area.");

        prompt = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "---- When have you felt the Holy Ghost this month?---",
            "---- Who are some of your personal heroes?---"
        };

        questions = new List<string>
        {

            " -",
            " -",
            " -",
            " -"
        };
    }

    public void runActivity()
    {
        runActivityParentStart();
        displayPrompt();
        displayQuestions();
        runActivityParentEnd();
    }

    public void displayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Consider the following:");
        Console.WriteLine();

        int randomIndex = new Random().Next(0, prompt.Count());
        Console.WriteLine(prompt[randomIndex]);
        Console.WriteLine();

        Console.WriteLine("Write your responses after pressing enter. ");
        Console.ReadLine();
    }
    public void displayQuestions()
    {
        List<int> indexes = new List<int>();
        
        for (int i= 0; i<4; i++)
        {
            int randomInt = new Random().Next(0, questions.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0,questions.Count());
            }
            indexes.Add(randomInt);
        }

        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        displayCountDown(5);

        foreach (int index in indexes)
        {
            Console.Write(questions[index]);
            displaySpinner((getUserSessionLengthInput() / indexes.Count()));
            Console.WriteLine();
        }
    }

}