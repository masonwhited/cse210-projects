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
        //create a series of if else if statements to determine and remove and replace a select number of words with underscores then displays it to the terminal.
        if (wordCount.Count() > 10)
        {
            for (int i = 0; i < 6; i++)
            {
                int randInt = rnd.Next(wordCount.Count());
                words[wordCount[randInt]].Hide();
                wordCount.RemoveAt(randInt);
            }
        }
        else if (wordCount.Count() > 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int randInt = rnd.Next(wordCount.Count());
                words[wordCount[randInt]].Hide();
                wordCount.RemoveAt(randInt);
            }
        }
        else
        {
            for (int i = 0; i < 1; i++)
            {
                int randInt = rnd.Next(wordCount.Count());
                words[wordCount[randInt]].Hide();
                wordCount.RemoveAt(randInt);
            }
        }
        foreach (Word word in words)
        {
            Console.Write($"{word.word} ");
        }
    }
}