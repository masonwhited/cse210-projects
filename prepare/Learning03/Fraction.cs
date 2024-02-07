using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
public class Fraction
{
    private int topNumber;
    private int bottomNumber;
    // Constructors
    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }
    public Fraction(int num)
    {
        topNumber = num;
        bottomNumber = 1;
    }
    public Fraction(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string line = $"{topNumber}/{bottomNumber}";
        return line;
    }
    public double GetDecimalValue()
    {
        return (double)topNumber / (double)bottomNumber;
    }
}