using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // declare variable
        int score = 0;
        string scoreText = "";
        string grade="";

        // input
        Console.Clear();
        Console.Write("Please enter your grade percentage : ");
        scoreText = Console.ReadLine();

        // user input checking
        if (!int.TryParse(scoreText, out score))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return; // stop the program
        }
        

        // if condition statements
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        // output
        Console.WriteLine();
        Console.WriteLine($"Your grade is {grade}");
    }
}