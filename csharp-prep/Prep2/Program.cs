using System;

class Program
{
    static void Main(string[] args)
    {
        //get the grade percentage from the user.
        Console.WriteLine("Please enter your grade percentage. ");

        //place the user input into a string variable
        string userInput = Console.ReadLine();

        //parse the string into an int variable
        int grade = int.Parse(userInput);

        //create a variable called letter
        string letter;

        //create a series of if else statements to determine the letter grade.
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //print the letter grade.
        Console.WriteLine($"You got an {letter}!");

        //determine if the grade is passing or failing and print a message stating so.
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time!");
        }
    }
}