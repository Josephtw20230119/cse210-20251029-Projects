
public class ChecklistGoal : Goal
{
    public int CurrentCount { get; private set; }
    public int RequiredCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints)
        : base(name, description, points)
    {
        RequiredCount = requiredCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override int RecordEvent()
    {
        if (IsComplete) return 0;

        CurrentCount++;

        if (CurrentCount >= RequiredCount)
        {
            IsComplete = true;
            return Points + BonusPoints;
        }

        return Points;
    }

    public override string DisplayGoalStatus()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description}) -- Currently completed: {CurrentCount}/{RequiredCount}";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{CurrentCount}|{RequiredCount}|{BonusPoints}|{IsComplete}";
    }

    public void RestoreChecklist(int currentCount, bool isComplete)
    {
        CurrentCount = currentCount;
        IsComplete = isComplete;
    }
}