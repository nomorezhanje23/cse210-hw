using System;

public class Comments
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Video> _video = new List<Video>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Comment:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Video video in _video)
        {
            // This calls the Display method on each job
            video.Display();
        }
    }
}