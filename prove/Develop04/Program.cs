using System;

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

            }
            else if (selection == 2)
            {

            }
            else if (selection == 3)
            {

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
                Console.WriteLine("Select Mindfulness Activity: \n____________________________ \n \n 1. Breathing Activity \n 2. Listing Activity \n 3. Reflection Activity \n 4. Quit");
                string input = Console.ReadLine();
                return int.Parse(input);
            }
        }
    }
}