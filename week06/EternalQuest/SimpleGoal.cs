public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        return "";
    }
    public override bool IsComplete()
    {
        return " ";
    }

    public override string GetStringRepresntations()
    {
        return "";
    }


}
