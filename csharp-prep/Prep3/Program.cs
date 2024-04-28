using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 101); // Generates a random number between 1 and 100
        int userNumber = 0;
        
        while (randomNumber != userNumber)
        {
            Console.Write("Give a guess: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (randomNumber > userNumber)
            {
                Console.WriteLine("Guess higher");
            }
            else if (randomNumber < userNumber)
            {
                Console.WriteLine("Guess lower");
            }
        }

        Console.WriteLine($"Congrats, you won! The answer was {randomNumber}");
    }
}