public class ListingActivity : Activity
{

    private Random random = new Random();

    private List<string> _questions = new List<string>();
    private int _duration;
    private string[] _prompts = new string[] 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public void Run(){
        _duration = DisplayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        DisplayPrompt();

        DisplayEndingMessage(AskQuestions());
    }

    private string GetRandomPrompts(){
        int randumNumber = random.Next(0, _prompts.Count());
            
        return _prompts[randumNumber];
    }
    private void DisplayPrompt(){
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompts()} ---");
        Console.Write("You WILL begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
    }

    private int AskQuestions(){
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        _questions.Clear();

        while (DateTime.Now < futureTime){
            Console.Write("> ");
            _questions.Add(Console.ReadLine());
            Console.WriteLine("");
        }
        Console.WriteLine($"Congrats you listed {_questions.Count} items!");
        ShowSpinner(3);


        TimeSpan elapsedTime = DateTime.Now - startTime;
        int intValue = (int)elapsedTime.TotalSeconds;
        return intValue;
    }
}