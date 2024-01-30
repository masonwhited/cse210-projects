using System.Reflection.Metadata.Ecma335;

namespace Journal;
using System;

class Program
{
    public Journal journal;
    static void Main(string[] args)
    {
        // Console.Clear();
        Run();
    }
    static public string GetPrompt()
    {
        string[] prompts = new string[5];
        prompts[0] = "Who was the most interesting person I interacted with today?";
        prompts[1] = "What was the best part of my day?";
        prompts[2] = "How did I see the hand of the Lord in my life today?";
        prompts[3] = "What was the strongest emotion I felt today?";
        prompts[4] = "If I had one thing I could do over today, what would it be?";
        Random random = new Random();
        int randomNumber = random.Next(0, 5);
        return prompts[randomNumber];
    }
    static public void Run()
    {
        bool keepGoing = true;

        while (keepGoing)
        {
            var selection = ShowMenu();

            if (selection == 1)
            {
                //Prompt user with a random prompt
                var prompt = GetPrompt();
                //Read in user input
                var Response = "temporary  response placeholder";
                var entry = new Entry(Response, prompt);
            }

            if (selection == 2)
            {
                //Display Entry 
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
        }
        static int ShowMenu()
        {
            Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Save File \n 4. Load File \n 5. Quit");
            string input = Console.ReadLine();
            return int.Parse(input);
        }
    }
    public void SaveToFile()
    {

    }
    public void LoadFromFile()
    {

    }
}