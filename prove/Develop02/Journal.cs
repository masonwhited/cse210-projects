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
        entries = new List<Entry>();
        foreach (var line in import)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void Display()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayString());
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.Export());
        }
        return exportLines.ToArray();
    }
}