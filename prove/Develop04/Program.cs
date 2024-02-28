using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static public void Run()
    {
        Activity activity = new Activity();
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            var selection = ShowMenu();

            if (selection == 1)
            {
                activity.DisplayBegin("Breathing Activity");
            }
            else if (selection == 2)
            {
                activity.DisplayBegin("Listing Activity");
            }
            else if (selection == 3)
            {
                activity.DisplayBegin("Reflection Activity");
            }
            else if (selection == 4)
            {
                Console.Clear();
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid Selection\nPlease try again.");
            }
            static int ShowMenu()
            {
                Console.WriteLine("Menu Options: \n_____________ \n \n 1. Breathing Activity \n 2. Listing Activity \n 3. Reflection Activity \n 4. Quit \n");
                Console.WriteLine("Select a choice from the menu:");
                string input = Console.ReadLine();
                return int.Parse(input);
            }
        }
    }
}