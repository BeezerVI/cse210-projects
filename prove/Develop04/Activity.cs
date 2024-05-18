public class Activity()
{  
    private string _name;

    private int _duration = 0;
    protected int DisplayStartingMessage(string name, string description){
        Console.WriteLine($"Welcome to {name}");
        Console.WriteLine("");
        Console.WriteLine(description);
        Console.WriteLine("");
        Console.Write("How long would you like this activity to last? ");
        string duration = Console.ReadLine();
        Console.Clear();
        Console.Write("Get Ready!");
        ShowSpinner(3);

        _name = name;
        _duration = int.Parse(duration);
        return _duration;
    }

    protected void DisplayEndingMessage(int duration = 0, int spinner = 2)
    {
        if (duration == 0)
        {
            duration = _duration;
        }

        Console.Clear();
        Console.Write("Well Done!");
        ShowSpinner(spinner);
        Console.WriteLine("");
        Console.Write($"Congrats! You finished {_name}, the time it took was {duration} seconds!");
        ShowSpinner(spinner);

    }

    protected void ShowSpinner(int seconds = 3){
        double I = 0;
        string[] spinner = new string[] { ":", ";", ",", ".", ":", "!", "'", ":", ";", ",", ".", ":", "!", "|", "\\", "-", "/", "|", "\\", "-", "/", "|", "\\", "-", "/", "|", "]", "}", ")", "}", "]", "|", "[", "{", "(", "{", "[", "|"};
        int index = 0;

        while(seconds > I){

        
        Console.Write(spinner[index]);
        index = (index + 1) % spinner.Length;

        Thread.Sleep(100);

        Console.Write("\b \b");
        I = I + 0.1;
        }
    }
    protected void ShowCountDown(int seconds = 5){
        double I = 0;
        int index = seconds;

        while(seconds > I){

        
        Console.Write(index);
        index = index - 1;

        Thread.Sleep(1000);

        Console.Write("\b \b");
        I = I + 1;
        }
    }
}