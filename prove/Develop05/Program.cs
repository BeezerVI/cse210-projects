using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        GoalManager goal = new GoalManager();
        Console.Clear();
        bool isTrue = true;
        while (isTrue == true){
            isTrue = goal.DisplayPlayerInfo();
        }
        Console.WriteLine("Good bye");
    }
}