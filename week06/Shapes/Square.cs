

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Square : Shape
{
    private double _side;
    public Square(string colorName,double side): base(colorName)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }

}