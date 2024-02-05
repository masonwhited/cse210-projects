using System.Globalization;

public class Fraction
{
    private int topNumber;
    private int bottomNumber;
    // Constructors
    public Fraction()
    {
        var number = "1/1";
        Console.WriteLine($"{number}");
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