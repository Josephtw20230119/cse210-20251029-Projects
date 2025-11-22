

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        if (_isHidden)
            return new string('_', _text.Length); // underscores match word length
        return _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}