using System;
using System.Globalization;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int number;
        int square;
        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        square = SquareNumber(number);
        DisplayResult(name, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string n = Console.ReadLine();
        int number = int.Parse(n);
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}