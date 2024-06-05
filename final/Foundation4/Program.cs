using System;

class Program
{
    static void Main(string[] args)
    {
        double DoubleUserResponse(string text = ""){
        Console.Write(text);
        string response = Console.ReadLine();
        double numberResponse = double.Parse(response);
        return numberResponse;
        }
        string StringUserResponse(string text = ""){
            Console.Write(text);
            string response = Console.ReadLine();
            return response;
        }
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(StringUserResponse("Please type down date for Running Activity "), DoubleUserResponse("How long did this activity last? "), DoubleUserResponse("what was your distance? ")),
            //new BicyclesActivity(StringUserResponse("Please type down date for Bicycles Activity "), DoubleUserResponse("How long did this activity last? "), DoubleUserResponse("what was your speed? ")),
            //new SwimmingActivity(StringUserResponse("Please type down date for Swimming Activity "), DoubleUserResponse("How long did this activity last? "), DoubleUserResponse("how maney laps did you take? "))
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine("----------");
            Console.WriteLine(activity.GetSummary());
        }
    }
}