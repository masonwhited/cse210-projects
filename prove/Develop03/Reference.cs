using System;
public class Reference
{
    //create a series of private variables to be referenced
    private string book;
    private int chap;
    private int startVerse;
    private int endVerse;
    //create a BuildReference method that will build and return the object with multiple verses.
    public string BuildReference(string book, int chap, int startVerse, int endVerse)
    {
        return $"{book} {chap}:{startVerse}-{endVerse}";
    }
    //create a BuildReference method that will build and return the object with a single verse.
    public string BuildReference(string book, int chap, int startVerse)
    {
        return $"{book} {chap}:{startVerse}";
    }

    //create a BuildReference method for creating the scriptural reference.
    public void BuildReference(string scripture)
    {
        //converts scripture into a list seperated by spaces
        var parts = scripture.Split(" ");
        //stores the first element of the list into a variable
        book = parts[0];
        //stores the second element of the list into a variable
        string location = parts[1];
        //seperates out the chapter and verses from the location and stores it in the parts variable
        parts = location.Split(":");
        //stores the first element as an int in the chap variable
        chap = int.Parse(parts[0]);
        //stores the second element in the verses variable
        string verses = parts[1];

        //checks if there is more than one verse and assigns them accordingly
        if (verses.Contains("-"))
        {
            parts = verses.Split("-");
            startVerse = int.Parse(parts[0]);
            endVerse = int.Parse(parts[1]);
        }
        //if there is no "-" then only one verse was given so store it directly in the startVerse variable
        else
        {
            startVerse = int.Parse(parts[1]);
        }
    }

    //creates a ReturnReference method that will return the scriptural reference as a string.
    public string ReturnReference()
    {
        if (endVerse == 0)
        {
            return $"{book} {chap}:{startVerse} ";
        }
        else
        {
            return $"{book} {chap}:{startVerse}-{endVerse} ";
        }
    }
}