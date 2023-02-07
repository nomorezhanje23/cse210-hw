class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        setActivityName ("Breathing Activity");

        setDescription ("This activity will help you relax by walking your" + 
        " through breathing in and out slowly." +
        "Clear your mind and focus on your breathing.");

    }

    public void runActivity()
    {
        runActivityParentStart();
        displaySession();
        runActivityParentEnd();
    }

    public void displaySession()

    {
       int input = 0;

        while( input < 1 )
        {
            Console.WriteLine("Breath in...");
            displayCountDown(4);
            Console.WriteLine("Breath out...");
            displayCountDown(6);

        }
        
    }

}