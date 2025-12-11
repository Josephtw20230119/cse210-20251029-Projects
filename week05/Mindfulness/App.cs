

using System.Collections;

public class App
{
    string _userChoice;
    bool _isContinue = true;
    UI _ui = new UI();
    public void Execute()
    {
        //UI ui = new UI();

        
        while (_isContinue)
        {
            _ui.ClearConsole();
            //ui.Clear_Condole();
            _ui.DisplayMenu();
            _userChoice = _ui.GetUserChoice();
            
            switch (_userChoice)
            {
                case "1":
                    /*
                    ui.ClearConsole();
                    BreathingActivity breathing_activity = new BreathingActivity();
                    breathing_activity.DisplayStartMessage();
                    breathing_activity.AskDuration();
                    ui.ClearConsole();
                    ui.DisplayGetReady();
                    ui.ShowSpinner(6);
                    breathing_activity.DoBreathingCycles();
                    breathing_activity.DisplayEndingMessage();
                    ui.ShowSpinner(6);
                    */
                    new BreathingActivity(_ui).Run();
                    //_ui.Pause();
                    // Console.WriteLine("Starting 1");
                    break;
                case "2":
                    // ReflectionActivity reflection_activity = new ReflectionActivity();
                    //reflection.Run();
                    /*
                    ui.ClearConsole();
                    ReflectionActivity reflection_activity = new ReflectionActivity();
                    reflection_activity.DisplayStartMessage();
                    reflection_activity.AskDuration();
                    ui.ClearConsole();
                    ui.DisplayGetReady();
                    ui.ShowSpinner(6);
                    reflection_activity.StartReflectionCycles();
                    reflection_activity.DisplayEndingMessage();
                    ui.ShowSpinner(6);
                    //Console.WriteLine("Starting 2");
                    
                    */
                    new ReflectionActivity(_ui).Run();
                    //_ui.Pause();
                    break;
                case "3":
                    /*
                    ui.ClearConsole();
                    ListingActivity listing_Activity = new ListingActivity();
                    listing_Activity.DisplayStartMessage();
                    listing_Activity.AskDuration();
                    ui.ClearConsole();
                    ui.DisplayGetReady();
                    ui.ShowSpinner(6);
                    listing_Activity.DisplayEndingMessage();
                    ui.ShowSpinner(6);
                    */
                    new ListingActivity(_ui).Run();
                    //Console.WriteLine("Starting Listing Activity...");
                    //_ui.Pause();
                    break;
                case "4":
                    _ui.DisplayMessage("Goodbye!");
                    _isContinue = false; 
                    break;
                default:
                    _ui.DisplayMessage("Invalid choice, try again.");
                    break;
            }
        }


    }



}