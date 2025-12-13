


using System.Runtime.CompilerServices;

public class Running:Activity
{
    private double _distance; // km 

    public Running(string activeDate, int minutes, double distance)
        : base( activeDate, minutes)
    {
        _distance = distance;
    } 
    public override double GetDistance()
    {
        return _distance;
    }



    public override double GetSpeed()
    {

        return _distance / (_minutes / 60.0); // km/h
    }

    public override double GetPace()
    {
        return _minutes / _distance; // min/km)
    }
/*
    public override string GetSummary()
    {
       return $"{_activityDate} Running ({_minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, " +
               $"Speed: {GetSpeed():0.00} km/h, " +
               $"Pace: {GetPace():0.00} min/km";
    }
*/
}