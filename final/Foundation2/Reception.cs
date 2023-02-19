class Reception : Event
{
    public Reception() : base()
    {
        setEventName ("Reception event");

        setDescription ("The email for RSVP is nomorezhaje100@gmail.com" + 
        " this event will take place on the 14th of May 2023" + 
        " at 2pm.");
    }

    public override runActivity()
    {
        runActivityParentStart();
      
    }

}