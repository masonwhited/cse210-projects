using Microsoft.VisualBasic;

public class Word
{
    //creates a variable to hold the string word
    public string word;

    // Replaces all non-punctuation characters in the current word with the underscore character ("_") to hide the word.
    public void Hide()
    {
        string blank = "";
        foreach (char a in word)
        {
            // Check if the character is punctuation
            if (!char.IsPunctuation(a))
                // If it's not punctuation, replace it with an underscore character
                blank += "_";
            else
                // If it's punctuation, keep the character as is
                blank += a;
        }
        // Set the current word to the new hidden string
        word = blank;
    }

}