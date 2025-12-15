


public class GoalHouse
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    
    public List<Goal> GetGoals() => _goals;
    public int GetTotalPoints() => _totalPoints;

    
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int RecordEvent(int index)
    {
        int earned = _goals[index].RecordEvent();
        _totalPoints += earned;
        return earned;
    }

    
    public void Save(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);

        // First line: total points
        writer.WriteLine(_totalPoints);

        // One goal per line
        foreach (Goal goal in _goals)
        {
            if (goal is SimpleGoal)
            {
                writer.WriteLine(
                    $"Simple|{goal.Name}|{goal.Description}|{goal.Points}|{goal.IsComplete}"
                );
            }
            else if (goal is EternalGoal)
            {
                writer.WriteLine(
                    $"Eternal|{goal.Name}|{goal.Description}|{goal.Points}"
                );
            }
            else if (goal is ChecklistGoal cg)
            {
                writer.WriteLine(
                    $"Checklist|{cg.Name}|{cg.Description}|{cg.Points}|" +
                    $"{cg.CurrentCount}|{cg.RequiredCount}|{cg.BonusPoints}|{cg.IsComplete}"
                );
            }
        }
    }


    public void Load(string filename)
    {
        if (!File.Exists(filename))
            return;

        string[] lines = File.ReadAllLines(filename);

        _totalPoints = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            switch (parts[0])
            {
                case "Simple":
                    var simple = new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])
                    );
                    simple.RestoreCompletion(bool.Parse(parts[4]));
                    _goals.Add(simple);
                    break;

                case "Eternal":
                    var eternal = new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])
                    );
                    _goals.Add(eternal);
                    break;

                case "Checklist":
                    var checklist = new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])
                    );
                    checklist.RestoreChecklist(
                        int.Parse(parts[4]),
                        bool.Parse(parts[7])
                    );
                    _goals.Add(checklist);
                    break;
            }
        }
    }
}