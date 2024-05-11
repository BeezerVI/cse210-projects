using System;
// Added a new function to prompt the user and ask them if they would want to insert their own scripture or take default
// Also made it so if you entered a number that many words would hide from the scripture
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture scripture = new Scripture();
        Console.WriteLine(scripture.GetDiaplyText());

        string userInput = "";
        while (userInput != "quit" && scripture.IsCompletelyHidden() == false){
            Console.Clear();
            Console.WriteLine(scripture.GetDiaplyText());
            scripture.HideRandomWord();
            Console.WriteLine("");
            Console.WriteLine("Enter 'quit' to exit the program. Enter any number to hide that many words.");
            userInput = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(userInput, out number);
            if (isNumber == true){
                number = int.Parse(userInput);
                scripture.HideRandomWord(number);
            }
            else{scripture.HideRandomWord(1);}

        }
        Console.Clear();
        Console.WriteLine(scripture.GetDiaplyText());
    }
}