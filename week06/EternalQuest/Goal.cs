

using System.Drawing;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    //protected string _type;
    public string  Name { get; protected set; }
    public string Description { get; protected set; }
    public  int Points { get; protected set; }
    public bool IsComplete { get; protected set; }
    public Goal(string name, string description, int points)
    {
        //_type = type;
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }
    public abstract int RecordEvent();
    //public abstract bool IsComplete();
    public abstract string DisplayGoalStatus();
    public abstract string GetSaveString();

    public void RestoreCompletion(bool isComplete)
    {
        isComplete = isComplete;
    }
    
    
    
}