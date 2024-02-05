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
    public void Numerator(int num)
    {
        topNumber = num;
        bottomNumber = 1;
        Console.WriteLine($"{topNumber}/{bottomNumber}");
    }
    public void Denominator(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
        Console.WriteLine($"{topNumber}/{bottomNumber}");
    }
}