class Writing : Assignment
{
    private string title;

    public Writing(string title, string name, string topic) : base(name, topic)
    {
        this.title = title;
    }

    public string GetWritingInformation()
    {
        return $"{name} -- {topic} \n Title: {title}\n";
    }
}