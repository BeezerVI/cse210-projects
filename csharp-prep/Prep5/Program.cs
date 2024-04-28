using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }
        
        static int SquareNumber(int number)
        {
            int root = number * number;
            return root;

        }

        static void DisplayResult(int root, string name)
        {
            Console.Write($"{name}, the square of your number is {root}");
        }

        Main();
        static void Main()
        {
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int root = SquareNumber(userNumber);
            DisplayWelcome();
            DisplayResult(root, userName);
        }
    }
}