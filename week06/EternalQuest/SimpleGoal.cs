using System.Drawing;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public int GetPoints() => _points;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You earned {_points} points for {_shortName}!");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal | {_shortName} | {_description} | {_points} | {_isComplete}";
    }
}
