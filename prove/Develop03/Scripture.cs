using System;
using System.Net;
using Microsoft.VisualBasic;
public class Scripture
{
    //create a variable to hold our scripture string
    public string scripture;

    // creates an instance of the Reference Class
    public Reference reference = new Reference();

    //create an instance of the Word Class
    public List<Word> words = new List<Word>();
    //creates a list of numbers for each word in the scripture text 
    public List<int> wordCount = new List<int>();

    //creates a method that passes the scripture into the BuildReference method and displays to the terminal
    public void DisplayReference()
    {
        reference.BuildReference(scripture);
        Console.Write($"\n{reference.ReturnReference()}");
    }

    //creates a method that displays the verse
    public void DisplayVerses()
    {
        //creates a list of words and stores it in the variable parts
        var parts = scripture.Split(" ");
        //creates a for loop to parse through the list of words, adds to the wordCount, and displays to the terminal
        for (int i = 2; i < parts.Count(); i++)
        {
            Word word = new Word();
            word.word = parts[i];
            wordCount.Add(i - 2);
            words.Add(word);
            Console.Write($"{parts[i]} ");
        }
    }

    //creates a method to hide random words in the scripture
    public void DisplayHide()
    {
        //creates an instance of Random
        Random rnd = new Random();
        // Check if the number of words is greater than 10
        if (wordCount.Count() > 10)
        {
            // If so, hide 6 random words
            for (int i = 0; i < 6; i++)
            {
                // Generate a random index within the range of the wordCount list
                int randInt = rnd.Next(wordCount.Count());

                // Hide the word at the random index
                words[wordCount[randInt]].Hide();

                // Remove the word from the wordCount list
                wordCount.RemoveAt(randInt);
            }
        }
        // Check if the number of words is greater than 3
        else if (wordCount.Count() > 3)
        {
            // If so, hide 3 random words
            for (int i = 0; i < 3; i++)
            {
                // Generate a random index within the range of the wordCount list
                int randInt = rnd.Next(wordCount.Count());

                // Hide the word at the random index
                words[wordCount[randInt]].Hide();

                // Remove the word from the wordCount list
                wordCount.RemoveAt(randInt);
            }
        }
        // If the number of words is less than or equal to 3
        else
        {
            // Hide 1 random word
            for (int i = 0; i < 1; i++)
            {
                // Generate a random index within the range of the wordCount list
                int randInt = rnd.Next(wordCount.Count());

                // Hide the word at the random index
                words[wordCount[randInt]].Hide();

                // Remove the word from the wordCount list
                wordCount.RemoveAt(randInt);
            }
        }

        // Print the remaining words to the console
        foreach (Word word in words)
        {
            Console.Write($"{word.word} ");
        }
    }
}