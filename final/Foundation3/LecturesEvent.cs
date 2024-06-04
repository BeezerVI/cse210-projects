public class LecturesEvent : Event 
{
    private string _speakerName;
    private int _capacity;

    public LecturesEvent(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
        public override void DisplayFullDetails(){
        Console.WriteLine($"\n{_title}\n{_description}\nThe event will start at {_date} at {_time}\nThe event will take place at {_address.GetFullAddress()}\nSpeaker for this event: {_speakerName}\nThere are {_capacity} seats.\nThis event will be a Lecture Event\n");
    }
    public override void DisplayShortDescription(){
        Console.WriteLine($"\nThis event is a Lecture Event\nName of event: {_title}\nStarting at {_date}\n");
    }
}