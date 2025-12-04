using System;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        /*
        Student student = new Student("Brigham","234");
        string name = student.Get_Name();
        string number = student.Get_Number();
        Console.WriteLine(name);
        Console.WriteLine(number);
        */
        /*
        Student student = new Student("Brigham", "234");
        string name = student.Name;
        string number = student.Number;
        Console.WriteLine(student.ToString());
        */
        
        Console.Clear();
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        //Console.WriteLine(assignment.ToString());
        Console.WriteLine($"{assignment.StudentName} - {assignment.Topic}");
        Console.WriteLine();
        
        
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez"
                                                         , "Fractions"
                                                         , "Section 7.3"
                                                         , "Problems 8-19");
            

        Console.WriteLine($"{mathAssignment.StudentName} - {mathAssignment.Topic}");
        Console.WriteLine($"{mathAssignment.TextbookSection} {mathAssignment.Problems}");
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters"
                                                                   , "European"
                                                                   , "The Causes of World War II by Mary Waters");
        Console.WriteLine($"{writingAssignment.StudentName} - {writingAssignment.Topic}");
        Console.WriteLine($"{writingAssignment.Title}");
    
    }
}

