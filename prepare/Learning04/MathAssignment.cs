class Math : Assignment
{
    private string textbookSection;
    private string problems;

    public Math(string textbookSection, string problems, string name, string topic) : base(name, topic)
    {
        this.textbookSection = textbookSection;
        this.problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{name} -- {topic} \n Section {textbookSection} Problems: {problems}\n";
    }
}