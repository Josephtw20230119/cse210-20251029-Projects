

public class Swimming:Activity
{
    private int _laps;  

    public Swimming(string activeDate, int minutes, int laps)
        : base( activeDate, minutes)
    {
        _laps = laps;
    } 
    public override double GetDistance()
    {
        return _laps * 50.0 /1000.0;
    }



    public override double GetSpeed()
    {

        return (GetDistance() / _minutes) * 60.0;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
/*
    public override string GetSummary()
    {
       return $"{_activityDate} Swimming ({_minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, " +
               $"Speed: {GetSpeed():0.00} km/h, " +
               $"Pace: {GetPace():0.00} min/km";
    }
*/
}