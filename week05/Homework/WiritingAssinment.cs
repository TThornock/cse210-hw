public class WritingAssinment : Assinment
{
    private string _title = "";

    public WritingAssinment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}"; 
    }
}