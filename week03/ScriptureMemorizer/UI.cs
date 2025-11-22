

public class UI
{

    public void Clear_Console()
    {
        Console.Clear();
    }

    public void Display_Scripture(Scripture scripture, bool hidden = false)
    {
        string[] words;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(scripture.Reference.Get_Reference());
        Console.ResetColor();
        

        if (hidden)
        {
            words = scripture.Get_HiddenWordsOnly().Split(' ');

            foreach (string word in words)
            {
                if (word == "____")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(word + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(word + " ");
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(scripture.Text);
            Console.ResetColor();
        }

    }
    public string Wait_ForEnter()
    {
        string input;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Press Enter to continue...or type quit to finish");
        Console.ResetColor();
        input = Console.ReadLine();
        
        if (input != null)
        {
            input = input.Trim();
            input = input.ToLower();
        }
        return input;
    }

    public void Display_EndingMessage()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("All words are hidden! Great job!");
        Console.ResetColor();

    }
    public void Display_QuitMessage()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("You chose to quit. Goodbye!");
        Console.ResetColor();
        
    }
} 