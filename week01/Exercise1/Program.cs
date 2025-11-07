using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // input
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        // output
        Console.WriteLine();
        Console.WriteLine($"Your name is {first_name}, {first_name} {last_name}.");
    }
}
/*
What is your first name? Scott
What is your last name? Burton

Your name is Burton, Scott Burton.
*/