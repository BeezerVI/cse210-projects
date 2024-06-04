public class OutdoorEvent : Event 
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }
        public override void DisplayFullDetails(){
        Console.WriteLine($"\n{_title}\n{_description}\nThe event will start at {_date} at {_time}\nThe event will take place at {_address.GetFullAddress()}\nThe weather will be {_weather}\nThis event will be a Outdoor Event\n");
    }
    public override void DisplayShortDescription(){
        Console.WriteLine($"\nThis event is a Outdoor Event\nName of event: {_title}\nStarting at {_date}\n");
    }
}