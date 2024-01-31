using System.Text;

namespace Journal;
public class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public Journal(string[] import)
    {

    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void Display()
    {

    }
    public string Export()
    {
        return "";
    }
}