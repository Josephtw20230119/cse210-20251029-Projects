using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();

        // Add different activities
        activities.Add(new Running("2025-02-10", 30, 4.8));   // 30 min, 4.8 km
        activities.Add(new Biking("2025-02-11", 45, 24.0));   // 45 min, 24 km/h
        activities.Add(new Swimming("2025-02-12", 20, 20));   // 20 min, 20 laps
        Console.Clear();
        // Display summaries using polymorphism
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}
    
