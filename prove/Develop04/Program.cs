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
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            var selection = ShowMenu();

            if (selection == 1)
            {
                string name1 = "Breathing Activity";
                Activity activity1 = new Activity(name1);
                Console.Clear();
                activity1.DisplayBegin();
            }
            else if (selection == 2)
            {
                string name2 = "Listing Activity";
                Activity activity2 = new Activity(name2);
                activity2.DisplayBegin();
            }
            else if (selection == 3)
            {
                string name3 = "Reflection Activity";
                Activity activity3 = new Activity(name3);
                activity3.DisplayBegin();
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