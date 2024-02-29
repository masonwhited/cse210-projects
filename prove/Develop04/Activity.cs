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
        WaitAnimate(1);
        Console.WriteLine($"{desc} \n");
        WaitAnimate(3);
    }

    public void DisplayEnd()
    {
        Console.WriteLine("Well Done! \n");
        WaitAnimate(2);
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

    public void WaitAnimate(int limit)
    {
        int loop = 0;
        while (loop < limit)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            loop += 1;
        }
    }
}