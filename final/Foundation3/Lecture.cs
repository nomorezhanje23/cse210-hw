class Lecture : Event
{
    public Lecture() : base()
    {
        setEventName ("Lecturer event");

        setDescription ("The speaker for this lecture is Dr Nomore T. Zhanje" + 
        " this event will take place on the 14th of May 2023" + 
        " at 2pm and it will accomnodate 5000 people.");
    }

    public override runActivity()
    {
        runActivityParentStart();
      
    }

}