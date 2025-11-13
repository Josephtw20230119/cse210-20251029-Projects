


public class App
{
    Menu menu = new Menu();
    Prompt prompt = new Prompt();
    string userChoice = "";
    //bool isContinue = true;
    public void Execute()
    {
        menu.Clear_Console();  
        menu.Display_Welcome_Message();
        while (menu.ShouldContinue())
        {
             
            menu.Display_A_BlankLine();
            menu.Display_Menu();
        
            menu.Set_UserChoice();
            userChoice = menu.Get_UserChoice();
            switch (userChoice)
            {
                case "1":
                    prompt.Get_RandomPrompt();
                    prompt.Display_RandomPrompt();
                    prompt.Display_InputPrompt();
                    prompt.Enter_UserAnswer();    
                //menu.Pause();
                break;
            case "2":
                //Console.WriteLine("Display");
                menu.Pause();
                break;
            case "3":
                Console.WriteLine("Load");
                //menu.Pause();
                break;
            case "4":
                Console.WriteLine("Save");
                //menu.Pause();
                break;
            case "5":
                //isContinue = false;
                //Console.WriteLine("Good Bye!");
                break;
            default:
                //Console.WriteLine("Invalid Choice! ");
                break;
        }

            
                
            
             
        }
        
        
    }
    
    
}