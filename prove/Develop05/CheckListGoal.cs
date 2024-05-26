public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    private bool _isComplete;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus, bool isComplete = false, int amountCompleted = 0) : base(shortName, description, points){
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _isComplete = isComplete;
        _amountCompleted = amountCompleted;
    }
    public override bool IsComplete(){return _isComplete;}
    public override string GetDetailsString(){return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";}
    public override string GetStringRepresentation(){return $"CheckListGoal~~{_shortName}~~{_description}~~{_points}~~{_target}~~{_bonus}~~{_isComplete}~~{_amountCompleted}";}

    public override int RecordEvent(){
        _amountCompleted = _amountCompleted + 1;
        if (_amountCompleted > _target){
            Console.WriteLine("You have already finshed this task.");
            return 0 ;
        }
        else{
            if (_amountCompleted == _target){
                Console.WriteLine($"Congratulations! You compleated {_shortName}! Way to go!");
                Console.WriteLine($"You just got the jake pot! {_bonus} points!");
                _isComplete = true;
                return _bonus;
            }
            else {
                Console.WriteLine($"Congratulations! You finshed {_shortName}!");
                Console.WriteLine($"You gained {_points} points!");
                return _points;
            }
        }
    }
}