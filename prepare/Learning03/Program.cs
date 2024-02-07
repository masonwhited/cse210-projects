using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Fraction first = new Fraction();
        var set1 = first.GetFractionString();
        Console.WriteLine(set1);
        var get1 = first.GetDecimalValue();
        Console.WriteLine(get1);

        Fraction second = new Fraction(5);
        var set2 = second.GetFractionString();
        Console.WriteLine(set2);
        var get2 = second.GetDecimalValue();
        Console.WriteLine(get2);

        Fraction third = new Fraction(3, 4);
        var set3 = third.GetFractionString();
        Console.WriteLine(set3);
        var get3 = third.GetDecimalValue();
        Console.WriteLine(get3);

        Fraction fourth = new Fraction(1, 3);
        var set4 = fourth.GetFractionString();
        Console.WriteLine(set4);
        var get4 = fourth.GetDecimalValue();
        Console.WriteLine(get4);
    }
}