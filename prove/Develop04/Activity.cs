class Activity
{
    private string name;
    private string desc;

    public Activity()
    {

    }
    public Activity(string name, string desc)
    {
        this.name = name;
        this.desc = desc;
    }

    public void DisplayBegin()
    {
        Console.WriteLine($"Welcome to the {name}. \n");
        Thread.Sleep(1000); // Pause for 1 second
        Console.WriteLine($"{desc} \n");
        Thread.Sleep(3000); // Pause for another 3 seconds
    }

    public int GetSeconds()
    {
        Console.WriteLine("How many seconds do you want to go for: ");
        var input = Console.ReadLine();
        return int.Parse(input) * 1000;
    }
}