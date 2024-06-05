using System;

class Program
{
    static void Main(string[] args)
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("03 Nov 2022", 30, 4.8),
            new BicyclesActivity("03 Nov 2022", 30, 20.0),
            new SwimmingActivity("03 Nov 2022", 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine("----------");
            Console.WriteLine(activity.GetSummary());
        }
    }
}