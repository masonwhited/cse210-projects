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
    public string GetPrompt()
    {
        return "";
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
                var prompt = "This is a random prompt";
                //Read in user input
                var placeholderResponse = "This is what the user typed in";
                var entry = new Entry(placeholderResponse, prompt);
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