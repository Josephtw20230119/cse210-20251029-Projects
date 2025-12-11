

public class  Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string colorName, double length,double width) : base(colorName)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }

}