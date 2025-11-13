


using System.Runtime.CompilerServices;

public class Menu
{
    static readonly string welcomeMessage = "Welcome to the Journal APP";
    static readonly string menu =
@"Please select one of the following choices: 
1.	Write 
2.	Display 
3.	Load  
4.	Save 
5.	Quit";
    static string userChoice = "";
    bool isContinue = true;
public void Clear_Console()
    {
        Console.Clear();
    }
    public void Display_Welcome_Message()
    {
        Console.WriteLine(welcomeMessage);
    }
    public void Display_A_BlankLine()
    {
        Console.WriteLine();
    }
    public void Display_Menu()
    {
        Console.WriteLine(menu);
    }
    public void Set_UserChoice()
    {
        Display_A_BlankLine();
        Console.Write("What would you like to do? ");
        userChoice = Console.ReadLine();
    }
    public bool ShouldContinue()
    {
        return isContinue;
    }
    public string Get_UserChoice()
    {


        switch (userChoice)
        {
            case "1":
                //Console.WriteLine("Write");

                break;
            case "2":
                Console.WriteLine("Display");
                break;
            case "3":
                Console.WriteLine("Load");
                break;
            case "4":
                Console.WriteLine("Save");
                break;
            case "5":
                isContinue = false;
                Console.WriteLine("Good Bye!");
                break;
            default:
                Console.WriteLine("Invalid Choice! ");
                break;
        }

        return userChoice;

    }
    public void Pause()
    {
        Display_A_BlankLine();
        Console.WriteLine(@"Press ENTER to continue...");
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