

public class Shape
{
    private string _colorName;
    public Shape(string colorName)
    {
        _colorName = colorName;
    }
    public string GetColor()
    {
        return _colorName;
    }
    public virtual double GetArea()
    {
        return 0;   
    }
}