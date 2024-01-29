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
    }
    public Entry(string import)
    {

    }
    public void Display()
    {

    }
    public string Export()
    {
        return "";
    }
}