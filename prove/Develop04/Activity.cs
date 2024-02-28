class Activity
{
    private string name;

    public Activity(string name)
    {
        this.name = name;
    }
    public void DisplayBegin()
    {
        Console.WriteLine($"Welcome to the {name}.");
    }
}