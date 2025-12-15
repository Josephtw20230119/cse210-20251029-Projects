


using System.Diagnostics;

public class UI
{
    readonly string _mainMenu = @"
Eternal Quest Menu
---------------------------
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Event
6. Quit
---------------------------
";
    readonly string _subMenu = @"
Choose Goal Type
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
";
  /*  readonly List<string> _qSetNewGoal = new List<string>()
    {
        "What type of goal do you want to create? ",
        "What is the name of your goal? ",
        "How many points do you get when you complete this goal? "
    };

    readonly List<string> _qCheckList = new List<string>()
    {
        "How many times do you need to complete this goal? ",
        "How many bonus  oints do youget after finishing the whole checklist? "
    };

*/
    public void DisplayMainMenu(int currentPoint)
    {
        Console.Clear();
        DisplayMessage($"\n🏆 You have {currentPoint} Points", ConsoleColor.Green);
        DisplayMessage(_mainMenu);
    }

    public void DisplaySubMenu()
    {
        DisplayMessage(_subMenu);
    }


    public void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    public void DisplayInLineMessage(string message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }
    public void ClearConsole()
    {
        Console.Clear();
    }

    public void BlankLine()
    {
        Console.WriteLine();
    }
    public void Pause()
    {
        Console.WriteLine("Press Enter to return to the menu");
        Console.ReadLine();
    }


    public string GetUserInput(string prompt)
    {
        Console.Write(prompt, ConsoleColor.White);
        return Console.ReadLine();
    }

    public string GetGoalTypeChoice()
    {
        DisplayMessage(_subMenu);
        string choice = GetUserInput("What type of goal would you like to create? (1-3): ");
        return choice;
    }

    public (string Name, string Description, int Points) GetCommonGoalDetails()
    {
        int points = 0;
        string name = GetUserInput("What is the name of your goal?");
        string description = GetUserInput("What is a short description of it? ");
        
        while (!int.TryParse(GetUserInput("How many points do you get when you complete this goal? "), out points) || points <= 0)
        {
            DisplayMessage("Invalid input. Please enter a positive number for points.", ConsoleColor.Red);
        }
        
        return (name, description, points);
    }
    


    // start a program 
    // the screen will show "The Goal Are : "
    // You have 0 points"
    // add FunctionMenu

    // 1.Careat a goal Questions List
    // Simple Goal
    // What type of goal would you like to create? "
    // What is the name of your goal? "
    // What is a short description of it? "
    // What is the amount of points associated with this goal? "

    // Check List
    // What type of goal would you like to create? "
    // What is the name of your goal? "
    // What is a short description of it? "
    // What is the amount of points associated with this goal? "
    // How many times does this goal need to be accomplished for a bonus? "
    // What is the bonus for accomplshing it that many time? "

    // 2. List Goals Display"
    // for example : "1. [] Goal name (description)"
    // "1. [] goal name (description) -- Currently completed: 0/3"

    // after save 

    // record event
    // Q Which qoal did you accomplish?
    // M Congratulation! You have earned 100 points!"
    // M You now have 150 points"

    // after you finished 
    // each finished goal will display like this itemNumber [X] Goal name (description)
}



