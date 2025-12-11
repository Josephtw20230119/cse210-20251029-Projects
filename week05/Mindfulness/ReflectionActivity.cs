


public class ReflectionActivity : Activity
{
    // Lists of prompts and questions for the activity (remain the same)
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity(UI ui) : base(
        "Reflection Activity \n",
        "This activity will help you reflect on times in your life\n" +
        "when you have shown strength and resilience.\n" +
        "This will help you recognize the power you have and how you can use it\n" +
        "in other aspects of your life."
        ,ui)
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        
        DisplayGetReady();
        StartReflectionCycles();
        DisplayEndingMessage();
    
    }
    public void StartReflectionCycles()
    {
        string prompt = GetRandomPrompt();
        _ui.BlankLine();
        _ui.DisplayMessage("Consider the following prompt:", ConsoleColor.Cyan);
        _ui.BlankLine();
        _ui.DisplayMessage($"--- {prompt} ---",ConsoleColor.Yellow);
        _ui.BlankLine();
        _ui.GetUserInput("When you have something in mind, press enter to continue.");

        _ui.BlankLine();
        _ui.DisplayInLineMessage("Now ponder on each of the following questions as they relate to this experience.");
        _ui.BlankLine();
        _ui.DisplayInLineMessage("You may begin in:");
        _ui.ShowCountdown(8);
        _ui.ClearConsole();
        //  Main reflection loop
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            // Calculate time remaining to ensure the loop doesn't run past the duration
            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
            if (remainingSeconds <= 0) break;

            // Randomly select one question
            string question = GetRandomQuestion();
            
            _ui.DisplayInLineMessage($"> {question} ",ConsoleColor.Yellow);

            // 3. INTERNAL PAUSE (Uses Thread.Sleep/Console.SetCursorPosition directly, 
            //    or a private helper method that does the same, since we cannot call ui.ShowSpinner).
            //    To show the spinner without passing UI, we must use a helper method inside THIS class.

            int pauseTime = Math.Min(8, remainingSeconds);
            _ui.ShowSpinner(pauseTime); 

            _ui.BlankLine(); 
        }
    }

    
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
}