public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _amountCompleted = _target;
            _points += _bonus;
        }

        Console.WriteLine($"Congratulations! You have earned {_points} points for {_shortName}!");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal";
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} : {_description} ({_amountCompleted}/{_target})";
    }
}