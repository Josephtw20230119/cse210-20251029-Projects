using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Declare Variable
        int count = 0;
        int magicNumber = 0;
        int userGuess = 0;
        string hintMessage = "";
        bool isContinue = true;
        string response = "";

        Random random = new Random();

        while(isContinue)
        {
            count = 0;
            Console.Clear();
            //Console.Write("What is the magic number? ");
            //magicNumber = int.Parse(Console.ReadLine());
            
            magicNumber = random.Next(1, 101);
            Console.WriteLine($"The Random Number is {magicNumber}");
            while (magicNumber != userGuess)
            {
                count = count + 1;
                // Input    

                Console.Write("Please enter your Number? ");




                // Check if userGuess is a valid number
                if (!int.TryParse(Console.ReadLine(), out userGuess))
                {
                    Console.WriteLine("Please enter a valid integer!");
                    continue;
                }

                if (magicNumber > userGuess)
                {
                    hintMessage = "Higher";
                    Console.WriteLine(hintMessage);
                }
                else if (magicNumber < userGuess)
                {
                    hintMessage = "Lower";
                    Console.WriteLine(hintMessage);
                }
                else
                {
                    hintMessage = "You guessed it!";
                    Console.WriteLine(hintMessage);
                }

            }
            // Output
            Console.WriteLine();
            Console.WriteLine($"You have guessed {count} times");
            Console.WriteLine();
            Console.Write($"Do you want to play again(yes/no)? ");
            response = Console.ReadLine().ToLower();
            isContinue = (response == "yes");
            
        }
        Console.WriteLine("Have a nice day!");
    }
}

/*
What is the magic number? 6
What is your guess? 4
*/