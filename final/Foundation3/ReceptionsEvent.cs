public class ReceptionsEvent : Event 
{
    private string _email;

    public ReceptionsEvent(string title, string description, string date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        _email = email;
    }
        public override void DisplayFullDetails(){
        Console.WriteLine($"\n{_title}\n{_description}\nThe event will start at {_date} at {_time}\nThe event will take place at {_address.GetFullAddress()}\nOur RSVP is at {_email}\nThis event will be a Receptions Event\n");
    }
    public override void DisplayShortDescription(){
        Console.WriteLine($"\nThis event is a Receptions Event\nName of event: {_title}\nStarting at {_date}\n");
    }
}