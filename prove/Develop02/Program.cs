using System.Reflection.Metadata.Ecma335;

namespace Journal;
using System;
using Microsoft.VisualBasic;

class Program
{
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
                Console.Clear();
                var prompts = new GetPrompt();
                //Prompt user with a random prompt
                string prompt = prompts.Prompt();
                //Displays prompt
                prompts.Display(prompt);
                //Read in user input
                string response = Console.ReadLine();
                //Add the response to the journal
                var entry = new Entry(response, prompt);
            }

            if (selection == 2)
            {
                //Display Entry 
                var journal = new Journal();
                Console.Clear();
                journal.Display();
            }

            if (selection == 3)
            {
                //Save to File

            }
            if (selection == 4)
            {
                //Load File
                LoadFromFile();
            }
            else if (selection == 5)
            {
                Console.Clear();
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
    static string[] LoadFromFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }
    static void SaveToFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }

}