

using System.Collections;

public class App
{
   // private int _totalPoint = 0;
    string _userChoice;
    bool _isContinue = true;
    UI _ui = new UI();
    //List<Goal> goals = new List<Goal>();
    private GoalHouse _goalHouse = new GoalHouse();
    public void Execute()
    {
        //UI ui = new UI();


        while (_isContinue)
        {
            _ui.ClearConsole();
            //_ui.DisplayMessage($"You have {_totalPoint} points");
            _ui.DisplayMainMenu(_goalHouse.GetTotalPoints());
            _userChoice = _ui.GetUserInput("Choose an option: ");
            

            switch (_userChoice)
            {
                case "1":
                    CreateNewGoal();
                    
                    //new BreathingActivity(_ui).Run();
                    
                    _ui.Pause();
                    break;
                case "2":
                    // ReflectionActivity reflection_activity = new ReflectionActivity();

                    //new ReflectionActivity(_ui).Run();
                    ListGoals();
                    _ui.Pause();
                    break;
                case "3":

                    //new ListingActivity(_ui).Run();
                    SaveGoals();
                    _ui.Pause();
                    break;
                case "4":
                    LoadGoals();
                    _ui.Pause();
                    break;
                case "5":
                    RecordGoalEvent();
                    _ui.Pause();
                    break;
                case "6":
                    _ui.DisplayMessage("Goodbye!");
                    _isContinue = false;
                    break;
                default:
                    _ui.DisplayMessage("Invalid choice, try again.");
                    break;
            }
        }




    }
    
    private void CreateNewGoal()
    {
        _ui.ClearConsole();
           _ui.DisplayMessage("Create a New Goal");

        string goalType = _ui.GetGoalTypeChoice();
        var goalData = _ui.GetCommonGoalDetails();

        Goal newGoal = BuildGoal(goalType, goalData);

        if (newGoal == null)
        {
            _ui.DisplayMessage("Goal not created.");
            return;
        }

        _goalHouse.AddGoal(newGoal);
        _ui.DisplayMessage($"Goal '{goalData.Name}' created successfully!");
    }    

private Goal BuildGoal(string goalType, (string Name, string Description, int Points) data)
    {
        switch (goalType)
        {
            case "1": // Simple
                return new SimpleGoal(data.Name, data.Description, data.Points);

            case "2": // Eternal
                return new EternalGoal(data.Name, data.Description, data.Points);

            case "3": // Checklist
                int required = int.Parse(_ui.GetUserInput("How many times to complete the goal? "));
                int bonus = int.Parse(_ui.GetUserInput("Enter bonus points: "));
                return new ChecklistGoal(
                    data.Name,
                    data.Description,
                    data.Points,
                    required,
                    bonus
                );

            default:
                _ui.DisplayMessage("Invalid goal type.");
                return null;
        }
    }

    private void ListGoals()
    {
       var goals = _goalHouse.GetGoals();

        if (goals.Count == 0)
        {
            _ui.DisplayMessage("No goals created yet.");
            return;
        }

        _ui.DisplayMessage("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            _ui.DisplayMessage($"{i + 1}. {goals[i].DisplayGoalStatus()}");
        }

 
}
   

    private void RecordGoalEvent()
    {
        var goals = _goalHouse.GetGoals();
        if (goals.Count == 0)
    {
        _ui.DisplayMessage("No goals available to record.");
        
        return;
    }

    
    _ui.DisplayMessage("Which goal did you accomplish?");
    for (int i = 0; i < goals.Count; i++)
    {
        _ui.DisplayMessage($"{i + 1}. {goals[i].DisplayGoalStatus()}");
    }

    
    int choice = 0;
    while (true)
    {
        string input = _ui.GetUserInput("Enter the number of the goal: ");
        if (int.TryParse(input, out choice) && choice > 0 && choice <= goals.Count)
        {
            break;
        }
        _ui.DisplayMessage("Invalid choice. Try again.", ConsoleColor.Red);
    }

    
    
    int earnedPoints = _goalHouse.RecordEvent(choice-1);
    

    
    _ui.DisplayMessage($"Congratulations! You earned {earnedPoints} points!", ConsoleColor.Green);
    _ui.DisplayMessage($"Your total points: {_goalHouse.GetTotalPoints()}", ConsoleColor.Green);
    }

    private void SaveGoals()
    {
        string filename = _ui.GetUserInput("Enter filename to save: ");
        _goalHouse.Save(filename);
        _ui.DisplayMessage("Goals saved successfully!");
    
    }
    private void LoadGoals()
    {
        string filename = _ui.GetUserInput("Enter filename to load: ");
        _goalHouse.Load(filename);
        _ui.DisplayMessage("Goals loaded successfully!");
    }

}