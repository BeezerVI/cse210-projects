public class BicyclesActivity : Activity
{
    double _speed;
    public BicyclesActivity(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double hours = _minutes / 60.0;// Convert minutes to hours by dividing by 60
        return _speed * hours;// Distance = Speed * Time
    }
    public override double GetSpeed(){
        return _speed;
    }
    public override double GetPace()
    {
        return Math.Ceiling((60 / _speed) * 100) / 100;
    }
    public override string GetClassName()
    {
        return "Stationary Bicycles";
    }
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
}