public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;


    public Goal(string name, string description, int points)
    {
        _shortName = name;

        _description = description;

        _points = points;
    }

    public abstract void RecordEvent()
    {
        return  " ";
    }

    public abstract bool IsComplete()
    {
        return " ";
    }

    public string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresntations()
    {
        return " ";
    }
}




