using System.Net;

namespace Journal;
public class Entry
{
    public string prompt;
    public string response;
    public string date;
    public string entry;
    public Entry(string response, string prompt)
    {
        this.response = response;
        this.prompt = prompt;
        date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        entry = $"{date} \n {prompt} \n {response}";
    }
    public void Display()
    {
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Response: " + response);
        Console.WriteLine("Date: " + date);
    }
    public string Export()
    {
        return "";
    }
}