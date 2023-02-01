namespace Ineheritance;

public class Cube : Shape, IShape
{
    public Cube(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }

    public double GetVolume()
    {
        return Length * Width * Height;
    }
}