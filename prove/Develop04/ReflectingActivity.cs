using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
public class ReflectingActivity() : Activity
{

    private Random random = new Random();

    private List<int> _claimedQuestions = new List<int>();

    private int _duration;
    private string[] _prompts = new string[] 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    public void Run(){
        _duration = DisplayStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _claimedQuestions.Clear(); //we clear the list before we use DisplayPrompt
        DisplayPrompt();
        DisplayEndingMessage(DisplayQuestions());
    }
    private string GetRandomQuestion(){
        if (_claimedQuestions.Count == _questions.Length)
        {
            return "full"; // If all prompts have been claimed
        }

        int randumNumber;
        
        // Ensure we get a unique random number not in _claimedQuestions
        do
        {
            randumNumber = random.Next(0, _questions.Length);
        } 
        while (_claimedQuestions.Contains(randumNumber));

        _claimedQuestions.Add(randumNumber);
        return _questions[randumNumber];
    }

    private string GetRandomPrompts(){
        int randumNumber = random.Next(0, _prompts.Count());
            
        return _prompts[randumNumber];
    }

    private void DisplayPrompt(){
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompts()} ---");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private int DisplayQuestions(){
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You will begin in: ");
        ShowCountDown(5);
        Console.Clear();
        

        int I = 0;

        while (I < _duration){
        Console.WriteLine(GetRandomQuestion());
        ShowSpinner(4);
        I = I + 4;            
        }
        return I;
    }
}