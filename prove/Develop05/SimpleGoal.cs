public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points, bool isComplete = false) : base(shortName, description, points){
        _isComplete = isComplete;
    }

    public override int RecordEvent(){
        if (_isComplete == true){
            Console.WriteLine($"You already compleated {_shortName}.");
            _isComplete = true;
            return 0;
        }
        else{
            Console.WriteLine($"Congratulations! You compleated {_shortName}!");
            Console.WriteLine($"You gained {_points} points!");
            _isComplete = true;
            return _points;
        }
    }
    public override bool IsComplete(){return _isComplete;}

    public override string GetDetailsString(){return $"{_shortName} ({_description})";}
    public override string GetStringRepresentation(){return $"SimpleGoal~~{_shortName}~~{_description}~~{_points}~~{_isComplete}";}
}