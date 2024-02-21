public class Assignment
{
    private string name;
    private string topic;

    public Assignment()
    {
    }

    public Assignment(string student, string subject)
    {
        name = student;
        topic = subject;
    }

    public string GetSummary()
    {
        return $"{name} -- {topic}";
    }
}