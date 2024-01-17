using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of numbers (type 0 to end)");
        List<int> numbers = new List<int>();
        int n;
        do
        {
            Console.WriteLine("Enter number: ");
            n = int.Parse(Console.ReadLine());
            numbers.Add(n);
        }
        while (n != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            n += numbers[i];
        }
        Console.WriteLine($"Sum = {n}.");

        float average = ((float)n) / (numbers.Count);
        Console.WriteLine($"Average = {average}.");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }
        Console.WriteLine($"Max = {max}.");
    }
}