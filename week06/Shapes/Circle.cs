

public class Circle: Shape
{
    private double _radius;
    public Circle(string colorName,double radius) : base(colorName)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}