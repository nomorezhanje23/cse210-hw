class Swimming : Activity
{
    public Swimming() : base()
    {
        setActivityName ("Swimming Activity");

        setDescription ("This activity mainly focuses on" + 
        " the pace covered by swimming");


    }

    public void runActivity()
    {
        runActivityParentStart();
        getSummary();
    }

    public void displaySummary()
    {
        Console.Clear();
        Console.Write("03 Nov 2022 Swimming (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile");

    }

}