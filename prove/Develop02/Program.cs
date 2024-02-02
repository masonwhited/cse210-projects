using System.Reflection.Metadata.Ecma335;

namespace Journal;
using System;
using Microsoft.VisualBasic;

class Program
{
    public Journal journal;
    public Entry entry;
    public GetPrompt prompts;
    static void Main(string[] args)
    {
        // Console.Clear();
        var journal = new Journal();
        Run();
    }

    static public void Run()
    {
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            var selection = ShowMenu();

            if (selection == 1)
            {
                var prompts = new GetPrompt();
                //Prompt user with a random prompt
                string prompt = prompts.Prompt();
                Console.WriteLine($"{prompt}: \n");
                //Read in user input
                string Response = Console.ReadLine();
                var entry = new Entry(Response, prompt);
                Console.Clear();
            }

            if (selection == 2)
            {
                //Display Entry 
                Console.Clear();
            }

            if (selection == 3)
            {
                //Save to File
            }
            if (selection == 4)
            {
                //Load File 
            }
            else if (selection == 5)
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid Selection\nPlease try again.");
            }
        }
        static int ShowMenu()
        {
            Console.WriteLine("Select Option: \n______________ \n 1. Add Entry \n 2. Display Entries \n 3. Save File \n 4. Load File \n 5. Quit");
            string input = Console.ReadLine();
            return int.Parse(input);
        }
    }
    static string SaveToFile()
    {
        return "";
    }
    static string[] LoadFromFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }
}