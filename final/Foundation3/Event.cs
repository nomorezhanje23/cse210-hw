using System.Diagnostics;

class Event
{
    
    private string startingMessage,title, description, date, time, address;

    public void setTime(string _date, string _time)
    {
        date =_date;
        time = _time;
    }

     public void setEventName(string _eventName)
    {
        eventName = _eventName;
    }

    public void setDescription(string _description)
    {
        description = _description;
    }

        public void displayStartingMessage()
    {
        startingMessage = string.Format("Welcome to the {0}.", title);
        Console.WriteLine(startingMessage);
        Console.WriteLine();
    }
    public void displayDescription()
    {
        Console.WriteLine(description);
        Console.WriteLine();
    }

      public void runActivityParentStart()
    {
        displayStartingMessage();
        displayDescription();
    }


    
}