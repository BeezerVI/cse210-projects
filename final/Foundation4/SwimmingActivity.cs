public class SwimmingActivity : Activity
{
    private double _laps;
    private const double _LapLength = 50; // length of a lap in meters

    public SwimmingActivity(string date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * _LapLength) / 1000; // converting meters to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetClassName()
    {
        return "Swimming";
    }
}
