public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;


    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails(){
        Console.WriteLine($"\n{_title}\n{_description}\nThe event will start at {_date} at {_time}\nThe event will take place at {_address.GetFullAddress()}\n");
    }
    public abstract void DisplayFullDetails();
    public abstract void DisplayShortDescription();
}