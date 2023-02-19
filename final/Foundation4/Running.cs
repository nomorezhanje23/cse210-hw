class Running : Activity
{
    public Running() : base()
    {
        setActivityName ("Running Activity");

        setDescription ("This activity mainly focuses on" + 
        " the distance covered by running");


    }

    public void runActivity()
    {
        runActivityParentStart();
        getSummary();
    }

    public void displaySummary()
    {
        Console.Clear();
        Console.Write("03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile");

    }

  
   

  
}