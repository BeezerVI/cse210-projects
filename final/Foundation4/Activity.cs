public abstract class Activity
{
    protected string _date;
    protected double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetClassName();
    public double GetMinutes()
    {
        return _minutes;
    }
    public string GetSummary()
    {
        return $"{_date} {GetClassName()} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}