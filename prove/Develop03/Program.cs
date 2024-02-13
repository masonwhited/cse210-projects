using System;
using System.Net;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        // Creates an instance of the Scripture class
        Scripture scripture = new Scripture();

        //creates a variable to hold the string scripture
        string script = "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        //string script = "Alma 12:27 But behold, it was not so; but it was appointed unto men that they must die; and after death, they must come to judgment, even that same judgment of which we have spoken, which is the end.";

        //passes the variable script into the variable scripture in the Scripture class
        scripture.scripture = script;

        //clears the terminal
        Console.Clear();
        //calls the DisplayReference function from the Scripture Class
        scripture.DisplayReference();
        //calls the DisplayVerses function from the Scripture Class
        scripture.DisplayVerses();

        //prompts the user to press the enter key or type out the word 'quit'
        Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish: ");
        //reads the response and passes it into a variable
        string response = Console.ReadLine();
        //create a while loop
        while (response != "quit")
        {
            //clears the terminal
            Console.Clear();
            //calls the DisplayReference function from the Scripture Class
            scripture.DisplayReference();
            //calls the DisplayHide function from the Scripture Class
            scripture.DisplayHide();

            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();

            //create an if statement stating that if wordCount == 0 then response = "quit"
            if (scripture.wordCount.Count() == 0) { response = "quit"; }
        }


    }
}