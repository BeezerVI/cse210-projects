using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Hyrum McKay", "Math sumthing about Pie");
        Console.WriteLine(assignment.GetSummery());
        MathAssignment math = new MathAssignment("Hyrum McKay", "Math sumthing about Pie", "7.3", "8-19");
        Console.WriteLine(math.GetHomeworkList());
        WritingAssignment writing = new WritingAssignment("Hyrum McKay", "Writing", "Haiku", "Thats one too maney silables bub");
        Console.WriteLine(writing.GetWritingInformation());
    }
}