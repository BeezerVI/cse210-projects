using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int  gradeNumber = int.Parse(userInput);
        string letter;

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (gradeNumber >= 70)
        Console.Write($"Your grade is {letter}, YOU PASSED! Congratulations! ");
        else
        Console.Write($"Your grade was {letter}, which is too low to pass. Now, at this point, I am legally supposed to encourage you to keep going. But that's hard. ");
    }
}