


class Journal
{
    List<Entry> _journal = new List<Entry>();
    public void AssignToJournal(Entry entry)
    {
        _journal.Add(entry);
    }
    public void Display_Journal()
    {
        if (_journal.Count == 0)
        {
            Console.WriteLine("The Journal is empty.");
            return;
        }

        foreach (Entry entry in _journal)
        {
            Console.WriteLine(entry.GetText());

        }
    }
    public List<Entry> Get_AllEntries()
    {
        return new List<Entry>(_journal);
    }
}