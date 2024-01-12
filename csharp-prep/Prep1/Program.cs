using System;

class Program
{
    static void Main(string[] args)
    {
        //Gather the name.
        Console.Write("What is your first name? ");
        //Enter it into a variable string.
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        //This is to add a blank line
        Console.WriteLine();
        //Print out the answer.
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}