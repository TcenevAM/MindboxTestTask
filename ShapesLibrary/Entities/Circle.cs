using ShapesLibrary.Entities.Interfaces;

namespace ShapesLibrary.Entities;

public class Circle : ICircle
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным числом.");
        }

        _radius = radius;
    }
    
    public double CalculateArea() => double.Pi * Math.Pow(_radius, 2);
}