class Activity
{
    private string name;
    private string desc;
    protected int seconds;

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

    public void DisplayEnd()
    {
        Console.WriteLine("Well Done! \n");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine($"You have completed another {seconds / 1000} seconds of the {name}.");
    }
    public void GetSeconds()
    {
        Console.WriteLine("How many seconds do you want to go for: ");
        var input = Console.ReadLine();
        seconds = int.Parse(input) * 1000;
    }

    public void Timer()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
    }
}