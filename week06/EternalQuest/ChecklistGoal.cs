public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    protected int _bonus;

    public int GetBonus() => _bonus;
    public int GetPoints() => _points;

    public ChecklistGoal(string name, string description, int points, int target, int bouns) : base(name, description, points) 
    {
        _target = target;
        _bonus = bouns;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Goal finished! you earned {_points + _bonus} points");
        }

        else
        {
            Console.WriteLine($"{_amountCompleted}/{_target} complete: You earned {_points} points.");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public new string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            _checkbox = "[X]";
            return $"{_checkbox}: {_shortName} ({_description}) -- currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            _checkbox = "[ ]";
            
            return $"{_checkbox}: {_shortName} ({_description}) -- currently completed {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {_shortName} | {_description} | {_points} | {_bonus} | {_target} | {_amountCompleted}";
    }
}