using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction();
        Console.WriteLine("Enter numerator: ");
        int numTop = int.Parse(Console.ReadLine());
        fraction.Numerator(numTop);
        Console.WriteLine("Enter denominator:");
        int numBottom = int.Parse(Console.ReadLine());
        fraction.Denominator(numTop, numBottom);
    }
}