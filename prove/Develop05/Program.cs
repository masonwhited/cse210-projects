using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Develop05 World!"); */
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

            }
            else if (selection == 5)
            {

            }
            else if (selection == 6)
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
            Console.WriteLine("Select Option: \n______________ \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            string input = Console.ReadLine();
            return int.Parse(input);
        }
    }
}