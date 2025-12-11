


using System.Drawing;

public class Activity
{
    public string ActivityName { get; }
    public string Description { get; }
    public int Duration { get; protected set; }
    protected readonly UI _ui;
    
    public Activity(string activityName, string description, UI ui)
    {
        ActivityName = activityName;
        Description = description;
        _ui = ui;
    }
    /*public void Run()
    {

    }*/
    public void DisplayStartMessage()
    {
        _ui.ClearConsole();
        _ui.DisplayMessage($"Welcome to the {ActivityName}.");
        _ui.DisplayMessage(Description);
        _ui.BlankLine();
        AskDuration();

    }
    
    public void AskDuration()
    {
        string initialPrompt = "How long, in seconds, would you like your session? ";
        string invalidPrompt = "Please enter a valid positive number: ";


        Duration = _ui.GetPositiveIntegerInput(initialPrompt, invalidPrompt);
    }

    public void DisplayGetReady()
    {
        _ui.ClearConsole();
        _ui.DisplayMessage("Get Ready...",ConsoleColor.Cyan);
        _ui.ShowSpinner(6);
    }
    public void DisplayEndingMessage()
    {
        _ui.BlankLine();
        _ui.DisplayMessage("Well Done!",ConsoleColor.Green);
        _ui.ShowSpinner(6);
        _ui.BlankLine();
        _ui.DisplayMessage($"You have completed the {ActivityName} for {Duration} seconds.");
        _ui.DisplayMessage("Thank you for taking time to calm your mind.");
        _ui.ShowSpinner(6);
    }

    
}
