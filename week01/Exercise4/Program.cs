using System;
using System.ComponentModel;
//using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int ttl = 0;
        int max = 0;
        Double avg = 0.0;
        bool isContinue = true;
        string strNumber = "";
        int intNumber = 0;
        bool success = true;
        int smallestPostive= 0;

        Console.Clear();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (isContinue)
        {

            Console.Write("Enter a number : ");
            strNumber = Console.ReadLine();
            if (strNumber == "0")
            {
                isContinue = false;
                break;

            }
            success = int.TryParse(strNumber, out intNumber);
            if (success)
            {
                numbers.Add(intNumber);
            }
            else
            {
                Console.WriteLine("Please enter a valid number. ");
            }

        }
        if (numbers.Count > 0)
        {
            ttl = numbers.Sum();
            avg = numbers.Average();
            max = numbers.Max();
            Console.WriteLine($"The sum is : {ttl}");
            Console.WriteLine($"The average is : {avg}");
            Console.WriteLine($"The largest number is : {max}");
            numbers.Sort();
            smallestPostive = numbers.FirstOrDefault(n => n > 0);
            Console.WriteLine($"The smallest positive number is : {smallestPostive}"); 
            Console.WriteLine("The sorted list is : ");
            
            foreach( int sortNum in numbers)
            {
                Console.WriteLine($"{sortNum}");
            }    
        }
        

    }
}

/*
Compute the sum, or total, of the numbers in the list.

Compute the average of the numbers in the list.

Find the maximum, or largest, number in the list.

The following shows the expected output:

Enter a list of numbers, type 0 when finished.
  Enter number: 18
  Enter number: 36
  Enter number: 2
  Enter number: 48
  Enter number: 6
  Enter number: 12
  Enter number: 9
  Enter number: 0
  The sum is: 131
  The average is: 18.714285714285715
  The largest number is: 48
  */