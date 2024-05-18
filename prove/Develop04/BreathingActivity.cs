public class BreathingActivity() : Activity
{
    public void Run()
    {
        int duration = DisplayStartingMessage("Breathing Activty", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // deraction / amount
        // amoaunt of seconds / how maney seconds the activity is
        int reapeat = duration / 10;
        int I = 0;
        while (I < reapeat)
        {
            Console.Clear();

            Console.Write("Breath In...");
            ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("Breath Out...");
            ShowCountDown(5);

            I = I + 1;
        }
        DisplayEndingMessage(I * 10);
    }
}