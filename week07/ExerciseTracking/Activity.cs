

using System.Runtime.CompilerServices;

public abstract class Activity
{
    protected string _activityDate;
    protected int _minutes;
    public Activity(string activityDate, int minutes)
    {
        _activityDate = activityDate;
        _minutes = minutes;

    }
    /*
    public string GetActivityDate()
    {
        return _activityDate;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    */
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_activityDate} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} km/h, " +
               $"Pace: {GetPace():0.0} min/km";
    }
    

}