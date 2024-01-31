using System.Net;

namespace Journal;
public class Entry
{
    public string prompt;
    public string response;
    public string date;
    public Entry(string response, string prompt)
    {
        this.response = response;
        this.prompt = prompt;
        date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
    }
    public void Display()
    {
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Response: " + response);
        Console.WriteLine("Date: " + date);
    }
    public void DisplayPrompt()
    {
        Console.Write("Prompt: " + prompt);
    }
    public string Export()
    {
        return "";
    }
}