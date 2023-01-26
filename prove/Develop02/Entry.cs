using System;

public class Entry
{
    public string _prompt;
    public string _answer;
    public string _date;

    public void Display()
    {
        Console.WriteLine ("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? "); 

        Console.WriteLine($"{_prompt} : {_answer} \n {_date}");
    }


}