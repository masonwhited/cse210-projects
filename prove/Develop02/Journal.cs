using System.Text;

namespace Journal;
public class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public Journal(string import)
    {
        string[] lines = import.Split('\n');
        int i = 0;
        while (i < lines.Length && !lines[i].StartsWith("##"))
            i++;
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry e in entries)
            Console.WriteLine(e.ToString());
    }
    public string Export()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Entry e in entries)
            sb.AppendLine(e.Export());
        return sb.ToString();
    }
}