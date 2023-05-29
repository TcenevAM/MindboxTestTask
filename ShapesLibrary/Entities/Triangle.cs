using ShapesLibrary.Entities.Interfaces;

namespace ShapesLibrary.Entities;

public class Triangle : ITriangle
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Длины сторон должны быть положительными числами.");
        }
        
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("Сумма двух сторон треугольника должна быть больше третьей стороны.");
        }

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CalculateArea()
    {
        return IsRightTriangle() ? CalculateRightTriangleArea() : CalculateTriangleArea();
    }

    private double CalculateTriangleArea()
    {
        var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
    }

    private double CalculateRightTriangleArea()
    {
        GetBaseAndHeight(out var baseLength, out var height);
        return baseLength * height / 2;
    }

    private bool IsRightTriangle()
    {
        return _sideA * _sideA + _sideB * _sideB - _sideC * _sideC == 0 ||
               _sideA * _sideA + _sideC * _sideC - _sideB * _sideB == 0 ||
               _sideB * _sideB + _sideC * _sideC - _sideA * _sideA == 0;
    }
    
    private void GetBaseAndHeight(out double baseLength, out double height)
    {
        baseLength = 0;
        height = 0;
        
        if (_sideA * _sideA + _sideB * _sideB - _sideC * _sideC == 0)
        {
            baseLength = _sideA;
            height = _sideB;
        }
        if (_sideA * _sideA + _sideC * _sideC - _sideB * _sideB == 0)
        {
            baseLength = _sideA;
            height = _sideC;
        }
        if (_sideB * _sideB + _sideC * _sideC - _sideA * _sideA == 0)
        {
            baseLength = _sideB;
            height = _sideC;
        }
    }
}