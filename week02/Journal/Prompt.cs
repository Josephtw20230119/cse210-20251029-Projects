


public class Prompt
{

    readonly List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I met today?",
        "What was the best part of my day?",
        "How did I feel God's help in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could redo one thing today, what would it be?",
        "What made me smile today?",
        "What is one new thing I learned today?",
        "Who helped me or made me happy today?",
        "What was a difficult moment today, and how did I handle it?",
        "What moment made me feel grateful today?",

        // 
        "If I could design a new video game, what would it be about?",
        "Imagine I woke up with a superpower — what would it be, and what would I do first?",
        "I discovered a secret door in my house or school — where does it lead?",
        "If people could live on another planet, what would life be like?",

        //
        "If I could switch lives with a cartoon character for one day, who would it be?",
        "Create a new ice cream flavor — what would it taste like?",
        "What would I do if I found a treasure chest in my backyard?",
        "Imagine a day when everything goes opposite — what would happen?",
        "If I could talk to a famous person from history, who would it be, and what would I ask?"
    };

    int index;
    Random random = new Random();
    string userAnswer = "";

    public void Get_RandomPrompt()
    {
        index = random.Next(prompts.Count());
    }
    public void Display_RandomPrompt()
    {

        Console.WriteLine(prompts[index]);
    }
    public void Display_InputPrompt()
    {
        Console.Write(">");
    }
    public void Enter_UserAnswer()
    {
        userAnswer = Console.ReadLine();
    }

        

}


