namespace Ineheritance;

public class Triangle : Shape, IShape
{
    public Triangle()
    {
    }

    public Triangle(double hypotenuse)
    {
        Hypotenuse = hypotenuse;
    }

    public Triangle(double hypotenuse, double height, double length)
    {
        Hypotenuse = hypotenuse;
        Height = height;
        Length = length;
    }

    public double Hypotenuse { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}