 using System;

namespace Developer05
{
    class EternalGoal : Goal

{
    private const int goalType = 2;

    private bool goalComplete;

    public EternalGoal()
    {     
    }
    public EternalGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete)
    : base(_goalName, _goalDescription, _points)
    {
        goalComplete = _goalComplete;
    }

    public override string toCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getGoalName(), getGoalDescription(),
            getGoalPoints(), goalComplete);
    }

    public override string ToString()
    {
        return string.Format("[{0}]{1} ({2})",((goalComplete == false)? " ":"X"),
            getGoalPoints(), goalComplete);
    }

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations!!! You have earned {0}", getGoalPoints()));
        goalComplete = true;
    }
}
}
