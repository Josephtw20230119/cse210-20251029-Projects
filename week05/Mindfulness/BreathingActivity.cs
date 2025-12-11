 
using System;
using System.Threading;

             
public class BreathingActivity : Activity
{
    //string ActivityName = "Breathing Activity";
    //string Description = "This activity helps you relax by guiding you through slow breathing.";
    public BreathingActivity(UI ui) : base("Breathing Activity \n"
    ,"This activity helps you relax by guiding you through slow breathing.\n" +
     "Clear your mind and focus on your breathing."
    ,ui)
    {

    }
    
    
    public void Run() {
        DisplayStartMessage();
        
        DisplayGetReady();
        DoBreathingCycles();
        DisplayEndingMessage();
    }

  /*  public void AskDuration() {
        Console.Write("How long, in seconds, would you like your session? ");
        Duration = int.Parse(Console.ReadLine());
    }
    */
    public void DoBreathingCycles() {

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now <= endTime)
        {
            _ui.BlankLine();
            _ui.DisplayInLineMessage("Breathe In...");
            _ui.ShowCountdown(4);
            _ui.BlankLine();
            _ui.DisplayInLineMessage("Now Breathe Out...");
            _ui.ShowCountdown(6);
            _ui.BlankLine();
        }
    }    
    
}