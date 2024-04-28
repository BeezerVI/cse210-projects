using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = 1;
        int sum = 0;
        int largestNumber = 0;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            numbers.Add(userNumber);
            sum += userNumber;
            if (largestNumber < userNumber)
            {
                largestNumber = userNumber;
            }

        }
        int count = numbers.Count - 1; // We add the -1 becuse 0 is added in the list at the end.
        Console.WriteLine($"The largest number is {largestNumber}");
        Console.WriteLine($"The sum is {sum}");
        int average = sum / count;
        Console.WriteLine($"The average is {average}");

    }
}