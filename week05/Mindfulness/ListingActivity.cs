


public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are places that you love to visit?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity(UI ui) : base(
    "Listing Activity \n"
    , "This activity will help you reflect on the good things in your life\n" + 
     "by having you list as many things as you can in a certain area."
    ,ui)
    {
    }

        // --- Method Hiding: The Hook for Common Flow ---

        // HIDES the base ExecuteActivity method. This is what the base 
        // ExecuteCommonFlow() will call.
        
        public void Run()
    {
        DisplayStartMessage();
        
        DisplayGetReady();
        StartListingCycles();
        DisplayEndingMessage();
    }
        
        // --- Unique Activity Logic ---

    public void StartListingCycles()
    {
        // 1. Choose and display a random prompt
        string prompt = GetRandomPrompt();

        _ui.BlankLine();
        _ui.DisplayMessage("Consider the following prompt:", ConsoleColor.Cyan);
        _ui.DisplayMessage($"--- {prompt} ---", ConsoleColor.Yellow);
        _ui.DisplayInLineMessage("You may begin in: ", ConsoleColor.White);
        _ui.ShowCountdown(5);  // Short countdown to think
        _ui.BlankLine();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        List<string> userItems = new List<string>();

        // Loop to collect user input until time is up
        while (DateTime.Now < endTime)
        {
            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
            if (remainingSeconds <= 0) break;

            _ui.DisplayInLineMessage("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userItems.Add(input.Trim());
            }
        }

        _ui.BlankLine();
        _ui.DisplayMessage($"You listed {userItems.Count} item(s)!");
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
}

