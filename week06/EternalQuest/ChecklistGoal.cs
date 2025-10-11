public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    ChecklistGoal(string name, string description, int points, int target, int bouns)
    {
        
    }
    '- In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. Then, it should set the amount completed to begin at 0.'

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        
    }

    public override string GetDetailsString()
    {
        
    }

    public override string GetStringRepresntations()
    {
        
    }
}