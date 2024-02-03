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
    public Entry(string import)
    {
        var parts = import.Split("|");
        date = parts[0];
        prompt = parts[1];
        response = parts[2];

    }
    public string DisplayString()
    {
        return $"{date} \n{prompt} \n{response}";
    }
    public string Export()
    {
        return $"{date}|{prompt}|{response}";
    }
}