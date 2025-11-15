

class FileManager
{

    string _fileName = "";

    public void Enter_FileName()
    {
        Console.Write("Enter a File Name to Save. ");
        _fileName = Console.ReadLine();
    }
    public List<Entry> Load_File()
    {
        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine();

        List<Entry> entries = new List<Entry>();

        foreach (string line in File.ReadAllLines(fileName))
        {
            entries.Add(new Entry(line));
            
        }

        Console.WriteLine("Journal loaded successfully!");
        return entries;

    }
    
    public void Save_File(List<Entry> entries)
    {
        Enter_FileName();
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.GetText());
                
            }
        }
        Console.WriteLine($"Journal is saved successfully to {_fileName}");
    }
    


}