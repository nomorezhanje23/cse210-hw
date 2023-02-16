
class AllGoals 
{
    private List<Goal> allGoals = new List<Goal>();

    private int totalPoints;

    public int getTotalPoints()
    {
        return totalPoints;
    }

    public void addGoal(Goal _goal)
    {
        allGoals.Add(_goal);
    }

    public void DisplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine(goal.ToString());
        }
    }
    public void SaveGoals()
    {
        if (allGoals.Count()== 0)
        {
            Console.WriteLine("There are no goals to save.");
            return;
        }
      //this will save the goals before the data is lost
        string fileToSave = DisplayGetGoalFile();
       /*if (File.Exists(fileToSave))
       {
        loadGoals();
       }*/

       List<string> saveGoals = new List<string>();

       saveGoals.Add(totalPoints.ToString());

       //Loops through all goals and convert them to a new CSV record which will be saved.
       foreach (Goal goal in allGoals)

       {
           saveGoals.Add(goal.ToCSVRecord());
       }

       SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);

       Console.WriteLine("Goals saved.");

    }
public void LoadGoals()//(string _filePath = "")
{
    List<string> fileGoals;
    /*if (File.Exists(_filePath))
    {
        fileGoals = SaveLoadCSV.LoadFromCSV(_filePath);
    }
    else
    {*/
        fileGoals = SaveLoadCSV.LoadFromCSV(DisplayGetGoalFile());
    //}
    Goal goal = null;
    foreach (string goalInFile in fileGoals)
    {
        string[] goalParts = goalInFile.Split('|');
        int goalType = int.Parse(goalParts[0]);
        switch(goalType)
        {
            case 1:
                goal = new SimpleGoal(goalParts[1], goalParts[2],int.Parse(goalParts[3]),
                   bool.Parse(goalParts[4]));
                break;       
        }
        if (goal != null && allGoals.Contains(goal) = false)
        {
            allGoals.Add(goal);
        }
    }
    Console.WriteLine("\nGoals loaded.\n");
}

public string DisplayGetGoalFile()
{
    Console.Write("What is the filename for the goal file? ");
    return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
}
public void DisplayGoalsRecordEvent()
{
    Console.WriteLine("The goals are:");
    foreach (Goal goal in allGoals)
    {
        Console.WriteLine(string.Format("{0} {1}", allGoals.index0f(goal)+ 1, goal.getGoalName()));
    }
    Console.Write("Which goals did you accomplish? ");
    int recordEvent = int.Parse(Console.ReadLine()) - 1;
    allGoals[recordEvent].RecordEvent();
    totalPoints += allGoals[recordEvent].getGoalPoints();
}

}
    


