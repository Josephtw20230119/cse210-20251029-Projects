using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        
        Console.Clear();
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        first.Blank_Line();
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        second.Blank_Line();
        Fraction third1 = new Fraction(3, 4);
        Console.WriteLine(third1.GetFractionString());
        Console.WriteLine(third1.GetDecimalValue());
        third1.Blank_Line();
        Fraction third2 = new Fraction(1, 3);
        Console.WriteLine(third2.GetFractionString());
        Console.WriteLine(third2.GetDecimalValue());
        
    
    }
}