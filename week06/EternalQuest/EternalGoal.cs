
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points ): 
        base(name, description, points)
    {
        
    }
    public override int RecordEvent()
    {
        return Points;
    }
    public override string DisplayGoalStatus()
    {

        string status = IsComplete ? "[X]" : "[ ]";

        return $"{status} {Name} ({Description})";
    }
    public override string GetSaveString()
    {
        return $"Eternal|{Name}|{Description}|{Points}";
    }
}
