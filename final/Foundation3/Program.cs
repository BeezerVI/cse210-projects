using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureEventAddress = new Address("123 Sky Lane", "Sky City", "SK", "Dubai");

        LecturesEvent lecturesEvent = new LecturesEvent("Sky", "Gather around to celebrate the 5th year anniversary of Sky children of light! We will be hearing from none other than Hyrum McKay himself talking about the development of the game!", "June 2, 2024", "12:00 pm", lectureEventAddress, "Hyrum McKay", 2000);

        Console.WriteLine("\n\n----------DisplayFullDetails----------");
        lecturesEvent.DisplayFullDetails();
        Console.WriteLine("----------DisplayStandardDetails----------");
        lecturesEvent.DisplayStandardDetails();
        Console.WriteLine("----------DisplayShortDescription----------");
        lecturesEvent.DisplayShortDescription();


        Address receptionsEventAddress = new Address("123 Maple Street", "Springfield", "IL", "Vanuatu");

        ReceptionsEvent receptionsEvent = new ReceptionsEvent("B-day", "Hello soon it will be Hyrum's birthday! Wow, we would like to gather as many people as possible to play Kahoot and other fun games with him!", "June 14, 2024", "2:45 PM", receptionsEventAddress, "hyrummckay@gmail.com");

        Console.WriteLine("\n\n----------DisplayFullDetails----------");
        receptionsEvent.DisplayFullDetails();
        Console.WriteLine("----------DisplayStandardDetails----------");
        receptionsEvent.DisplayStandardDetails();
        Console.WriteLine("----------DisplayShortDescription----------");
        receptionsEvent.DisplayShortDescription();


        Address outdoorEventAddress = new Address("456 Elm Avenue", "Lakeside", "CA", "Canada");

        OutdoorEvent outdoorEvent = new OutdoorEvent("Sim Day", "Sim Day is an all-new special event where people come to play in a simulated environment outdoors!", "December 21, 2024", "10:30 AM", outdoorEventAddress, "Partly Cloudy");

        Console.WriteLine("\n\n----------DisplayFullDetails----------");
        outdoorEvent.DisplayFullDetails();
        Console.WriteLine("----------DisplayStandardDetails----------");
        outdoorEvent.DisplayStandardDetails();
        Console.WriteLine("----------DisplayShortDescription----------");
        outdoorEvent.DisplayShortDescription();
    }
}