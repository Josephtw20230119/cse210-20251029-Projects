

using System.Security.Cryptography.X509Certificates;

public class Entry
{
    private string _text;

    public Entry(string text)
    {
        _text = text;  
    }

    public string GetText()
    {
        return _text;  
    }
}