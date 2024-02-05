using System.Globalization;

public class Fraction
{
    private int topNumber;
    private int bottomNumber;
    // Constructors
    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
        Console.WriteLine($"{topNumber}/{bottomNumber}");
    }
    public Fraction(int num)
    {
        topNumber = num;
        bottomNumber = 1;
        Console.WriteLine($"{topNumber}/{bottomNumber}");
    }
    public Fraction(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
        Console.WriteLine($"{topNumber}/{bottomNumber}");
    }
}