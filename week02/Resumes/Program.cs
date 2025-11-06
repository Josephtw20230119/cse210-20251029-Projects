using System;

class Program
{

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");
        Resume resume1 = new Resume();
        resume1.Display();
        Job job1 = new Job("Software Engineer" 
                            , "Microsoft"
                            , 2019
                            , 2022
                            );

        job1.Display();
        
        Job job2 = new Job("Manager"
                            , "Apple"
                            , 2022
                            , 2023
                            );
        job2.Display();
        
    }
}

