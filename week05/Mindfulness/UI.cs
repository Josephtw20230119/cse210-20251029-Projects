


using System.Diagnostics;

public class UI
{
    readonly string _menu =@"
Menu Options
1. Start breathing activity
2. Start reflecting activity
3. Start Listing activity
4. Quit
";

    string _userChoice;
    public void DisplayMenu()
    {
        Console.WriteLine(_menu);
    }
    public string GetUserChoice()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Select a choice from the menu: ");
        Console.ResetColor();
        _userChoice = Console.ReadLine();
        return _userChoice;
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
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            DisplayInLineMessage(spinner[i]);
            Thread.Sleep(250);

            Console.Write("\b \b");
            //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

            i = (i + 1) % spinner.Length;
        }

        //Console.Write("   ");
        //Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop);
        //Console.WriteLine();
        BlankLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
            //Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop);
        }
        //Console.Write("    "); // Clear the final number space
        //Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop);
    }

    public int GetPositiveIntegerInput(string initialPrompt, string invalidPrompt)
    {
        int result = 0;
        Console.Write(initialPrompt);
        while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.WriteLine(invalidPrompt);
            Console.WriteLine(initialPrompt); // Re-prompt
        }

        return result;
    }
    public string GetUserInput(string prompt)
    {
        Console.Write(prompt,ConsoleColor.White);
        return Console.ReadLine();
    }
    
}



