using System;
using System.Globalization;



class Program(string[] args)
{
    static string userName = "";
    //int intNumber = 0;
    //string strNumber = "";
    static int userNumber = 0;
    static int squareNumber = 0;

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult();


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static void PromptUserName()
    {
        
        Console.Write("Please enter you name : ");
        userName = Console.ReadLine();
    }
    static void PromptUserNumber()
    {
        string strNumber = "";
    
        bool success;
        Console.Write("Please enter you favorite number : ");
        strNumber = Console.ReadLine();

        success = int.TryParse(strNumber, out userNumber);
        if (!success)
        {
            Console.WriteLine("Please Enter a valid Number!");
        }
    }
    static void SquareNumber()
    {
        squareNumber = userNumber * userNumber;
    }
    static void DisplayResult()
    {
        Console.WriteLine(userName);
       Console.WriteLine($"{userName}, the square of you number is {squareNumber}");
    }


}

/*
Welcome to the program!
Please enter your name: Brother Burton
Please enter your favorite number: 42
Brother Burton, the square of your number is 1764
*/