class OutdoorGathering : Event
{
    public OutdoorGathering() : base()
    {
        setEventName ("Outdoor Gathering event");

        setDescription ("The weather forcast is partly cloudy." + 
        " This event will take place on the 14th of May 2023" + 
        " at 2pm and it will accomnodate 5000 people.");
    }

    public override runActivity()
    {
        runActivityParentStart();
      
    }

}