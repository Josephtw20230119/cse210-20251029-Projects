

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Reference // Where the scriptdudre comes from
{
    string _book;
    string _chapter;
    string _verseStart;
    string _verseEnd;
    bool _isRange;

    // only one verse
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse;
    }

    // more than one verse
    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _isRange = verseStart != verseEnd;


    }
    public string Get_Reference()
    {
        if (_isRange){
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        else {
            
            return $"{_book} {_chapter}:{_verseStart}";
        }
    }
    

}

