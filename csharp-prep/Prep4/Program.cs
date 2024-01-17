using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int n;
        do
        {
            Console.WriteLine("Please enter a number: ");
            n = int.Parse(Console.ReadLine());
            numbers.Add(n);
        }
        while (n != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            n += numbers[i];
        }
        Console.WriteLine($"Sum = {n}.");
    }
}