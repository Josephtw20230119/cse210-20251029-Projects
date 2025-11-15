


using System.Runtime.CompilerServices;

public class UI
{
    static readonly string _welcomeMessage = "Welcome to the Journal APP";
    static readonly string _menu =
@"Please select one of the following choices: 
1.	Write 
2.	Display 
3.	Load  
4.	Save 
5.	Quit";
    
    bool _isContinue = true;
public void Clear_Console()
    {
        Console.Clear();
    }
    public void Display_Welcome_Message()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(_welcomeMessage);
        Console.ResetColor();
    }
    public void Display_A_BlankLine()
    {
        Console.WriteLine();
    }
    public void Display_Menu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(_menu);
        Console.ResetColor();
        Console.Write("What would you like to do? ");
    }
    
    public bool Should_Continue()
    {
        return _isContinue;
    }
    
    public string Get_UserChoice()
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(x+1, y);
        string choice = Console.ReadLine();
        if (choice == "5")
        {
            _isContinue = false;
            Console.WriteLine(" Good Bye ! ");
        }
        return choice;
        
    }
    
    public void Pause()
    {
        Display_A_BlankLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(@"Press ENTER to continue...");
        Console.ResetColor();
        Console.ReadLine();

    }
}






/*
Please select one of the following choices:
1.	Write
2.	Display
3.	Load
4.	Save
5.	Quit
What would you like to do?
*/