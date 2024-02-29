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
        Activity activity = new();
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            var selection = ShowMenu();

            if (selection == 1)
            {
                string name1 = "Breathing Activity";
                string desc1 = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Activity activity1 = new Activity(name1, desc1);
                Console.Clear();
                activity1.DisplayBegin();
                activity.GetSeconds();
                activity.DisplayEnd();
            }
            else if (selection == 2)
            {
                string name2 = "Listing Activity";
                string desc2 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Activity activity2 = new Activity(name2, desc2);
                Console.Clear();
                activity2.DisplayBegin();
                activity.GetSeconds();
                activity.DisplayEnd();
            }
            else if (selection == 3)
            {
                string name3 = "Reflection Activity";
                string desc3 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Activity activity3 = new Activity(name3, desc3);
                Console.Clear();
                activity3.DisplayBegin();
                activity.GetSeconds();
                activity.DisplayEnd();
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