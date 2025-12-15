

using System.Drawing;

public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    

    }


    public override int RecordEvent()
    {
        
        if (IsComplete)
        {
            Console.WriteLine($"Goal '{Name}' is already complete. No points awarded.");
            return 0;
        }

        
        IsComplete = true; 
        
        
        return Points;     
    }
    public override string DisplayGoalStatus()
    {

        string status = IsComplete ? "[X]" : "[ ]";

        return $"{status} {Name} ({Description})";
    }

    public override string GetSaveString()
    {
        return $"Simple|{Name}|{Description}|{Points}|{IsComplete}";
    }
}