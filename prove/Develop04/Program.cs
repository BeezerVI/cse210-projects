using System;
// Modified the GetRandomQuestion function in ReflectingActivity class to ensure that a different random prompt is displayed if the one chosen has already been used. This is for creativity past core rerequirements.
//I did this one --> Make sure no random prompts/questions are selected until they have all been used at least once in that session.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        BreathingActivity breathingactivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        int numberResponse = 0;
        while (numberResponse != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1: Start Breathing Activty");
            Console.WriteLine("    2: Start Reflecting Activity");
            Console.WriteLine("    3: Start Listing Activty");
            Console.WriteLine("    4: Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();
            numberResponse = int.Parse(response);

            if (numberResponse == 1){
                breathingactivity.Run();
            }
            else if (numberResponse == 2){
                reflectingActivity.Run();
            }
            else if (numberResponse == 3){
                listingActivity.Run();
            }
            else{
                Console.Clear();
                Console.WriteLine("Goog Bye!");
                Thread.Sleep(3000);
                Console.WriteLine("I mean.");
                Thread.Sleep(1000);
                Console.WriteLine("Are you shure you want to go?");
                Thread.Sleep(2000);
                Console.WriteLine("Ok alright bye for real.");
            }
        }
    }
}