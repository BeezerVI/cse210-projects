public class Reference
{
    // Default Jacob 6:12 O be wise; what can I say more?
    private string _book = "Jacob";
    public string _scripture = "O be wise; what can I say more?";
    private int _chapter = 6;
    private int _verse = 12;
    private int _endVerse = 12;

    public Reference()
    {
        Console.Clear();
        Console.WriteLine("Would you like to insert your own scripture? (type 'yes' for yes and anything else for no)");
        string userInput = Console.ReadLine();
        if (userInput == "yes")
        {
            UserOutputReference();
        }
    }

    public void UserOutputReference()
    {
        Console.Clear();
        Console.WriteLine("Which book is it from? ");
        _book = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What chapter? (numbers only) ");
        _chapter = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Are there multiple verses? (type yes if there are otherwise anything else for no) ");
        string userInput = Console.ReadLine();


        if (userInput == "yes")
        {
            Console.Clear();
            Console.WriteLine("What is the starting verse? ");
            _verse = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("What is the last verse? ");
            _endVerse = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.Clear();
            Console.WriteLine("What is the verse? ");
            _verse = int.Parse(Console.ReadLine());
            _endVerse = _verse;

        }
        Console.Clear();
        Console.WriteLine("Last one. What is the scripture?");
        _scripture = Console.ReadLine();
    }

    public string GetReferenceString()
    {
        string returnValue;
        if (_verse == _endVerse)
        {
            returnValue = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            returnValue = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return returnValue;
    }
}
