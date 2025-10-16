using System.Security.Cryptography.X509Certificates;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected string _checkbox;

    public Goal(string name, string description, int points)
    {
        _shortName = name;

        _description = description;

        _points = points;
    }


    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            _checkbox = "[X]";
            return $"{_checkbox}: {_shortName} ({_description})";
        }

        else
        {
            _checkbox = "[ ]";
            return $"{_checkbox}: {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();
}




