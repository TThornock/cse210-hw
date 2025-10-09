using System.Reflection.Metadata.Ecma335;

public class Assinment
{
    protected string _studentName;
    protected string _topic;

    public Assinment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummery()
    {
        return _studentName + "-" + _topic;
    }
}