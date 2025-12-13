

public class Biking:Activity
{
    private double _speed; // km/h  

    public Biking(string activeDate, int minutes, double speed)
        : base( activeDate, minutes)
    {
        _speed = speed;
    } 
public override double GetDistance()
    {
        return _speed * (_minutes / 60.0); 
    }
    public override double GetSpeed()
    {
        return _speed;
    }    
    public override double GetPace()
    {
        return 60.0 / _speed; 
    } 
    
    /*
    public override string GetSummary()
    {
       return $"{_activityDate} Biking ({_minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, " +
               $"Speed: {GetSpeed():0.00} km/h, " +
               $"Pace: {GetPace():0.00} min/km";
    }
*/
}




/*






    */