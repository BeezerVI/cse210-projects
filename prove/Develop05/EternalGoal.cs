public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points){
    }

    public override int RecordEvent(){
        Console.WriteLine($"Congratulations! You compleated {_shortName}!");
        Console.WriteLine($"You gained {_points} points!");
        return _points;
        
    }
    public override bool IsComplete(){return false;}
    public override string GetDetailsString(){return $"{_shortName} ({_description})";}
    public override string GetStringRepresentation(){return $"EternalGoal~~{_shortName}~~{_description}~~{_points}";}
}